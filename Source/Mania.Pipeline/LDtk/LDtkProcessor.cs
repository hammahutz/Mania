using Microsoft.Xna.Framework.Content.Pipeline;
using Mania.Library.LDtk;
using System.Text.Json;
using System;
using Mania.Library;

namespace Mania.Pipeline.LDtk;
[ContentProcessor(DisplayName = "LDtkProcessor")]
class LDtkProcessor : ContentProcessor<string, LDtkData>
{
    public override LDtkData Process(string input, ContentProcessorContext context)
    {
        LDtkData ldtkData = new LDtkData();
        try
        {
            if (input.IsNullOrEmpty())
            {
                throw new Exception("LDtk data string is null or empty");
            }

            ldtkData = JsonSerializer.Deserialize<LDtkData>(input);
        }
        catch (Exception e)
        {
            GameDebug.Warning($"Tries to load LDtk data but failed: {e}");
        }
        return ldtkData;
    }
}
