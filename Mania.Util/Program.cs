using System.Text;

namespace Mania.Util;

class Program
{
    static void Main(string[] args)
    {
        string contentFolderPath = @"../Mania.Core/Content";
        string contentFolderName = "Content";
        string contentFolderFullPath = $"{contentFolderPath}/{contentFolderName}";
        string className = "ContentPath";

        StringBuilder classContent = new StringBuilder();

        classContent.AppendLine($"public static class {className}");
        classContent.AppendLine("{");

        string[] folderPaths = Directory.GetDirectories(contentFolderFullPath);

        foreach (string folderPath in folderPaths)
        {
            System.Console.WriteLine(folderPath);
            string folderName = folderPath.Replace($"{contentFolderFullPath}", "");
            classContent.AppendLine($"\tpublic static class {folderName}");
            classContent.AppendLine("\t{");

            string[] filePaths = Directory.GetFiles(folderPath);

            foreach (string filePath in filePaths)
            {
                string constantName = Path.GetFileNameWithoutExtension(filePath).Replace(contentFolderPath, "");

                classContent.AppendLine($"\t\tpublic const string {constantName} = @\"{filePath}\";");
            }



            classContent.AppendLine("\t}");
        }
        classContent.AppendLine("}");

        // Console.WriteLine(classContent.ToString());

        File.WriteAllText("./ContentPath.css", classContent.ToString());

    }
}
