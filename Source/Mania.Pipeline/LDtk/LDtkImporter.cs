using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;

namespace Mania.Pipeline.LDtk;

[ContentImporter(".ldtk", DisplayName = "LDtkImporter", DefaultProcessor = "LDtkProcessor")]
public class LDtkImporter : ContentImporter<string>
{
    public override string Import(string filename, ContentImporterContext context)
    {
        string stream;
        using (var reader = new StreamReader(filename))
        {
            stream = reader.ReadToEnd();
        }
        return stream;
    }
}
