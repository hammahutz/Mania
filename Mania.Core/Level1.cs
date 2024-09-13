using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mania.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Core;

public class Level1 : Scene
{
    public override void Draw(SpriteBatch spriteBatch)
    {
        throw new NotImplementedException();
    }

    public override void Update(GameTime gameTime)
    {
        ChangeScene(new Level1());
        throw new NotImplementedException();
    }
}
