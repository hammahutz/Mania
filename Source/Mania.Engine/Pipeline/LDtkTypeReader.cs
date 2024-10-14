using Mania.Engine.GameLogic.Nodes.LDtk;
using Microsoft.Xna.Framework.Content;

namespace Mania.Engine.Pipeline;
public class LDtkTypeReader : ContentTypeReader<LDtkNode>
{
    protected override LDtkNode Read(ContentReader input, LDtkNode existingInstance) => new LDtkNode(input.ReadString());

}
