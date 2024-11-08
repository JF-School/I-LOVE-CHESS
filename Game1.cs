using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace I_LOVE_CHESS
{
    public class Game1 : Game
    {
        Texture2D rectTexture;
        Rectangle testRect;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.ApplyChanges();
            this.Window.Title = "Cheese";
            testRect = new Rectangle(0, 0, 80, 80);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectTexture = Content.Load<Texture2D>("rectangle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SaddleBrown);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            for (int x = 0; x < _graphics.PreferredBackBufferWidth; x += 160)
            {
                for (int y = 0; y < _graphics.PreferredBackBufferHeight; y += 160)
                {
                    _spriteBatch.Draw(rectTexture, new Rectangle(x, y, 80, 80), Color.Tan);
                    _spriteBatch.Draw(rectTexture, new Rectangle(((x - 80) * 3), (y - 80), 80, 80), Color.Tan);
                }
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
