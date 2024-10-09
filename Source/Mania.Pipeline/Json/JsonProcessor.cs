using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;
using Microsoft.Xna.Framework.Content.Pipeline;

using TInput = System.String;
using TOutput = Mania.Pipeline.Json.JsonProcessorResult;

namespace Mania.Pipeline.Json;

[ContentProcessor(DisplayName = "Json Processor - Hammahutz")]
class JsonProcessor : ContentProcessor<TInput, TOutput>
{
    [DisplayName("Minify Json")]
    public bool Minify { get; set; } = true;

    [DisplayName("Runtime Identifier")]
    public string RuntimeIdentifier { get; set; } = string.Empty;

    public override TOutput Process(TInput input, ContentProcessorContext context)
    {
        if (string.IsNullOrEmpty(RuntimeIdentifier))
            throw new Exception("No Runtime Identifier was specified for this JSON content");

        if (Minify)
            input = MinifyJson(input);

        return new TOutput() { Json = input, RuntimeIdentifier = RuntimeIdentifier };
    }

    private static string MinifyJson(string input)
    {
        var document = JsonDocument.Parse(input);
        var options = new JsonWriterOptions()
        {
            Indented = false,
        };

        using (var stream = new MemoryStream())
        {
            using (var writer = new Utf8JsonWriter(stream, options))
            {
                document.WriteTo(writer);
                writer.Flush();
            }
            return Encoding.UTF8.GetString(stream.ToArray());
        }

    }

}
