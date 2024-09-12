using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;

using TInput = Mania.Pipeline.Json.JsonProcessorResult;

namespace Mania.Pipeline.Json;

[ContentTypeWriter]
class JsonTypeWriter : ContentTypeWriter<TInput>
{
    private string _runtimeIdentifier;
    public override string GetRuntimeReader(TargetPlatform targetPlatform)
    {
        // Type Path
        // [Type Path], [Assembly]
        // "Mania.Pipeline.JsonReader, Mania.PipeLine"
        return _runtimeIdentifier;
    }

    protected override void Write(ContentWriter output, TInput value)
    {
        _runtimeIdentifier = value.RuntimeIdentifier;
        output.Write(value.Json);
    }
}
