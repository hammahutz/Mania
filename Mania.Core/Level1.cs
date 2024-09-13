using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Mania.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mania.Core;

public class Level1 : Scene
{
    public Level1(Game game) : base(game)
    {
    }

    SpriteFont font;
    protected override void LoadContent()
    {
        font = GlobalContent.Load<SpriteFont>("Debug");
    }
    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, "Hello from level1", new Vector2(100,100), Color.Red);
    }

    public override void Update(GameTime gameTime)
    {
        Debug.Print("Hello");
    }
}
