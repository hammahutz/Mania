using System.Dynamic;
using System.Text;
using CommandLine;

namespace Mania.Util;

class Settings
{
    [Value(0, MetaName = "Project Folder Root Path", Required = true, HelpText = "Monogame project path")]
    public string ProjectFolderRootPath { get; set; } = ".";
    public string OutputClassName { get; set; } = "ContentPaths";
    public string ContentFolderPath { get => $"{ProjectFolderRootPath}/Content"; }
    public string[] IgnoreFolders = ["bin", "obj"];
    public string[] IgnoreFiles = ["Content.mgcb"];


    [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
    public bool Verbose { get; set; }
    public void Debug(string text) { if (Verbose && !silent) Console.WriteLine(text); }
    public void Print(string text) { if (!silent) Console.WriteLine(text); }

    [Option('s', "silent", Required = false, HelpText = "No messages")]
    public bool silent { get; set; }
}


class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Settings>(args)
        .WithParsed(settings =>
        {
            StringBuilder classContent = new StringBuilder();

            settings.Debug($"{settings.OutputClassName}" + " : {");

            classContent.AppendLine($"public static class {settings.OutputClassName}");
            classContent.AppendLine("{");
            RecursiveRead(settings.ContentFolderPath, classContent, settings, 1);
            classContent.AppendLine("}");

            settings.Debug("}");

            File.WriteAllText(@$"{settings.ProjectFolderRootPath}/{settings.OutputClassName}.cs", classContent.ToString());

            settings.Print($"File saved successfully to {settings.ProjectFolderRootPath}/{settings.OutputClassName}.cs");
        })
        .WithNotParsed(errs =>
        {
            Console.WriteLine("Error argument. Use --help.");
        });
    }

    static void RecursiveRead(string path, StringBuilder classContent, Settings settings, int depth)
    {
        string classTab = "";
        for (int i = 0; i < depth; i++)
        {
            classTab += "\t";
        }
        string[] folderPaths = Directory.GetDirectories(path);

        foreach (string folderPath in folderPaths)
        {

            string folderName = folderPath.Replace(@$"{path}\", "");
            if (settings.IgnoreFolders.Contains(folderName))
                continue;

            settings.Debug($"{classTab}{folderName}" + " : {");
            classContent.AppendLine($"{classTab}public static class {folderName}");
            classContent.Append($"{classTab}");
            classContent.Append("{\n");
            RecursiveRead(folderPath, classContent, settings, depth + 1);

            string[] filePaths = Directory.GetFiles(folderPath);
            string fileTab = "";
            for (int i = 0; i < depth + 1; i++)
            {
                fileTab += "\t";

            }
            foreach (string filePath in filePaths)
            {
                if (settings.IgnoreFiles.Contains(filePath))
                    continue;

                string constantPath = Path.GetFileName(filePath).Replace(path, "");
                string constantName = Path.GetFileNameWithoutExtension(constantPath).Replace(path, "");
                string constantValue = filePath
                    .Replace(settings.ContentFolderPath, "")
                    .Split('.')
                    [0];

                settings.Debug($"{fileTab}{constantName} = {constantValue}");


                classContent.AppendLine($"{fileTab}public const string {constantName} = @\"{constantValue}\";");
            }
            classContent.Append($"{classTab}");
            classContent.Append("}\n");

            settings.Debug($"{classTab}" +"}");
        }
    }
}


