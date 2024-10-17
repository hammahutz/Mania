
using System.Text.Json;
using Mania.Library.LDtk;
using Microsoft.Xna.Framework.Content;

namespace Mania.Library.Pipeline;
public class LDtkTypeReader : ContentTypeReader<LDtkData>
{
    protected override LDtkData Read(ContentReader input, LDtkData existingInstance)
    {
        if (existingInstance is null)
        {
            return existingInstance;
        }
        try
        {
            return JsonSerializer.Deserialize<LDtkData>(input.ReadString());
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}


