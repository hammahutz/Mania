using Microsoft.Xna.Framework.Content;

namespace MonoLDtk.Shared.LDtkProject;
public class LDtkReader : ContentTypeReader<LDtkRoot>
{
    protected override LDtkRoot Read(ContentReader input, LDtkRoot existingInstance) => new LDtkRoot(input.ReadString());

}
