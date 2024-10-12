using System.Linq.Expressions;
using System.Text;
using CommandLine;

namespace Mania.Util;

public class Settings
{
    [Value(0, MetaName = "Project Folder Root Path", Required = false, HelpText = "Monogame project path")]
    public string ProjectFolderRootPath { get; set; } = ".";

    [Option('s', "source", Required = false, HelpText = "Content source")]
    public string ContentFolderPath { get; set; } = "../../Content/Dist";

    [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
    public bool Verbose { get; set; }

    [Option('n', "no-messages", Required = false, HelpText = "No messages")]
    public bool Silent { get; set; }

    public string OutputClassName { get; set; } = "ContentPaths";
    public List<string> IgnoreFolders { get; set; } = ["bin", "obj"];
    public List<string> IgnoreFiles { get; set; } = ["Content.mgcb"];
}


class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Settings>(args)
            .WithParsed(GenerateContentPathClass)
            .WithNotParsed(errs => Console.WriteLine("Error argument. Use --help."));
    }

    static void GenerateContentPathClass(Settings settings)
    {
        Logger.Settings = settings;

        var generator = new ContentPathClassGenerator(settings);
        string content = generator.Generate();
        string savePath = $"{Path.Combine(settings.ProjectFolderRootPath, settings.OutputClassName)}.cs";

        File.WriteAllText(savePath, content);
        Logger.Print($"File saved successfully to {savePath}");
    }
}
static class Logger
{
    public static Settings Settings { get; set; } = new Settings();
    public static void Log(string text) { if (Settings.Verbose && !Settings.Silent) Console.WriteLine(text); }
    public static void Print(string text) { if (!Settings.Silent) Console.WriteLine(text); }
}

class ContentPathClassGenerator
{
    public Settings Settings { get; private set; }
    public ContentPathClassGenerator(Settings settings) => Settings = settings;



    public string Generate()
    {
        var classContent = new StringBuilder();

        Logger.Print($"Generating content path class");
        Logger.Log($"{Settings.OutputClassName}" + " : {");

        classContent.AppendLine($"public static class {Settings.OutputClassName}");
        classContent.AppendLine("{");

        classContent.Append(RecursiveFolderToClass(Settings.ContentFolderPath, 1));

        classContent.AppendLine("}");
        Logger.Log("}");

        Logger.Print($"File generate successfully");
        return classContent.ToString();
    }


    private string RecursiveFolderToClass(string path, int indents)
    {
        var classContent = new StringBuilder();
        string[] folderPaths = Directory.GetDirectories(path);
        string classIndents = new string('\t', indents);

        foreach (string folderPath in folderPaths)
        {
            string folderName = folderPath.Replace(path, "").Substring(1);
            if (Settings.IgnoreFolders.Contains(folderName))
                continue;


            Logger.Log($"{classIndents}{folderName}" + " : {");

            classContent.AppendLine($"{classIndents}public static class {folderName}");
            classContent.Append($"{classIndents}");
            classContent.Append("{\n");

            classContent.Append(RecursiveFolderToClass(folderPath, indents + 1));
            classContent.Append(FilesToStrings(folderPath, indents));

            classContent.Append($"{classIndents}");
            classContent.Append("}\n");

            Logger.Log($"{classIndents}" + "}");
        }

        return classContent.ToString();
    }

    private string FilesToStrings(string folderPath, int indents)
    {
        var classContent = new StringBuilder();
        string[] filePaths = Directory.GetFiles(folderPath);
        string fileIndents = new string('\t', indents + 1);

        foreach (string filePath in filePaths)
        {
            if (Settings.IgnoreFiles.Contains(filePath))
                continue;

            string constantName = Path.GetFileNameWithoutExtension(filePath);
            string constantValue = filePath.Replace(Settings.ContentFolderPath, "").Split('.')[0].Substring(1);

            Logger.Log($"{fileIndents}{constantName} = {constantValue}");

            classContent.AppendLine($"{fileIndents}public const string {constantName} = @\"Content/{constantValue}\";");
        }

        return classContent.ToString();
    }
}


