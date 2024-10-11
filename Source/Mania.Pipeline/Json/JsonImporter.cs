using System;
using System.IO;
using System.Text.Json;
using Microsoft.Xna.Framework.Content.Pipeline;

using TImport = System.String;

namespace Mania.Pipeline.Json;

[ContentImporter(".json", DisplayName = "Json Importer - Hammahutz", DefaultProcessor = nameof(JsonProcessor))]
public class JsonImporter : ContentImporter<TImport>
{
    public override TImport Import(string filename, ContentImporterContext context) => LoadAndCheckJsonFile(filename);

    private string LoadAndCheckJsonFile(string filename)
    {
        string json = File.ReadAllText(filename);
        if (string.IsNullOrEmpty(json))
        {
            throw new InvalidContentException("The JSON file is empty");
        }
        try
        {
            _ = JsonDocument.Parse(json);
        }
        catch (Exception ex)
        {
            throw new InvalidContentException("This does not appear to be a valid JSON file. See inner exception for details", ex);
        }
        return json;
    }
}
