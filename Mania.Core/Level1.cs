using System.Collections.Generic;
using Mania.Engine;
using Mania.Engine.GameActors;
using Mania.Engine.GameActors.Vector;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mania.Core;

public class Level1 : Scene
{
        public GraphicsDevice GraphicsDevice { get; private set; }
        private SpriteFont _debugFont;

        private Line _line;

        public Level1(GraphicsDevice graphicsDevice) => GraphicsDevice = graphicsDevice;

        protected override void LoadContent()
        {
                _line = new Line(GraphicsDevice, new Vector2(10, 10), new Vector2(100, 100), new Point(2, 2));
                _debugFont = GlobalContent.Load<SpriteFont>(ContentPaths.SpriteFont.Debug);
                Actors.Add(new Dot(GraphicsDevice, new Vector2(10, 10), new Point(10, 10)));
                Actors.Add(new Dot(GraphicsDevice, new Vector2(100, 100), new Point(10, 10)));

                Actors.Add(_line);
        }

        public override void UpdateScene(GameTime gameTime)
        {
                if (Keyboard.GetState().IsKeyDown(Keys.Space))
                        ChangeScene(new Level2(GraphicsDevice));
                _line.EndPosition = Mouse.GetState().Position.ToVector2();
        }

        public override void DrawScene(SpriteBatch spriteBatch)
        {
                string platform;
#if DIRECTX
        platform = "DirectX";
#elif OPENGL
        platform = "OpenGL";
#elif ANDROID
        platform = "Android";
#else
                platform = "the void!?";
#endif

                spriteBatch.DrawString(_debugFont, $"Hello world from {platform}", Vector2.Zero, Color.GreenYellow);
                spriteBatch.DrawString(_debugFont, "Hello from Level1", new Vector2(100, 100), Color.Red);
        }

        protected override void UnloadContent()
        {
        }
}
