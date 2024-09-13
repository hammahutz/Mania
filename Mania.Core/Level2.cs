using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mania.Core.Data.Pipeline.Json;
using Mania.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class Level2 : Scene
{
    private SpriteFont _debugFont;

    protected override void LoadContent()
    {
        _debugFont = GlobalContent.Load<SpriteFont>("Debug");
    }

    public override void Update(GameTime gameTime)
    {
         if (Keyboard.GetState().IsKeyDown(Keys.Space))
            ChangeScene(new Level1());
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(_debugFont, "Hello from Level2", new Vector2(100, 100), Color.Red);
    }

    protected override void UnloadContent()
    {
    }
}
