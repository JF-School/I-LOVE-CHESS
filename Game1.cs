using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace I_LOVE_CHESS
{
    public class Game1 : Game
    {
        Texture2D rectTexture;
        // chess
        Texture2D redPawnTexture, redRookTexture, redHorseTexture, redKnightTexture, redKingTexture, redQueenTexture;
        Texture2D bluePawnTexture, blueRookTexture, blueHorseTexture, blueKnightTexture, blueKingTexture, blueQueenTexture;

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
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectTexture = Content.Load<Texture2D>("rectangle");
            // chess
            redPawnTexture = Content.Load<Texture2D>("redsoldier");
            bluePawnTexture = Content.Load<Texture2D>("bluesoldier");
            redRookTexture = Content.Load<Texture2D>("redrook");
            blueRookTexture = Content.Load<Texture2D>("bluerook");
            redHorseTexture = Content.Load<Texture2D>("redhorse");
            blueHorseTexture = Content.Load<Texture2D>("bluehorse");
            redKnightTexture = Content.Load<Texture2D>("redknight");
            blueKnightTexture = Content.Load<Texture2D>("blueknight");
            redKingTexture = Content.Load<Texture2D>("redcrown");
            blueKingTexture = Content.Load<Texture2D>("bluecrown");
            redQueenTexture = Content.Load<Texture2D>("redqueen");
            blueQueenTexture = Content.Load<Texture2D>("bluequeen");
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

            for (int x = 0; x < 4; x += 1)
            {
                for (int y = 0; y < 8; y += 1)
                {
                    _spriteBatch.Draw(rectTexture, new Rectangle(x * 160 + (y % 2 * 80), y * 80, 80, 80), Color.Tan);
                }
            }
            for (int x = 0; x < 10; x += 1)
            {
                _spriteBatch.Draw(redPawnTexture, new Rectangle(x * 80, 80, 80, 80), Color.White);
                _spriteBatch.Draw(bluePawnTexture, new Rectangle(x * 80, 480, 80, 80), Color.White);
            }
            for (int x = 0; x < 2; x += 1)
            {
                _spriteBatch.Draw(redRookTexture, new Rectangle(x * 560, 0, 80, 80), Color.White);
                _spriteBatch.Draw(blueRookTexture, new Rectangle(x * 560, 560, 80, 80), Color.White);
            }
            _spriteBatch.Draw(redHorseTexture, new Rectangle(80, 0, 80, 80), Color.White);
            _spriteBatch.Draw(redHorseTexture, new Rectangle(480, 0, 80, 80), Color.White);
            _spriteBatch.Draw(blueHorseTexture, new Rectangle(80, 560, 80, 80), Color.White);
            _spriteBatch.Draw(blueHorseTexture, new Rectangle(480, 560, 80, 80), Color.White);

            _spriteBatch.Draw(redKnightTexture, new Rectangle(160, 0, 80, 80), Color.White);
            _spriteBatch.Draw(redKnightTexture, new Rectangle(400, 0, 80, 80), Color.White);
            _spriteBatch.Draw(blueKnightTexture, new Rectangle(160, 560, 80, 80), Color.White);
            _spriteBatch.Draw(blueKnightTexture, new Rectangle(400, 560, 80, 80), Color.White);

            _spriteBatch.Draw(redKingTexture, new Rectangle(240, 0, 80, 80), Color.White);
            _spriteBatch.Draw(blueKingTexture, new Rectangle(240, 560, 80, 80), Color.White);
            _spriteBatch.Draw(redQueenTexture, new Rectangle(320, 0, 80, 80), Color.White);
            _spriteBatch.Draw(blueQueenTexture, new Rectangle(320, 560, 80, 80), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
