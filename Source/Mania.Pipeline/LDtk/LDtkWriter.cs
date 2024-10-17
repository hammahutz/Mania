using System.Text.Json;
using Mania.Library.LDtk;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;


namespace Mania.Pipeline.LDtk;

[ContentTypeWriter]
public class LDtkWriter : ContentTypeWriter<LDtkData>
{

    protected override void Write(ContentWriter output, LDtkData ldtk) => output.Write(JsonSerializer.Serialize(ldtk));
    public override string GetRuntimeReader(TargetPlatform targetPlatform) => "Mania.Library.Pipeline.LDtkTypeReader, Mania.Library";
}