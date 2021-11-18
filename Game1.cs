using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Sprite player;
        Sprite enemy;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()

        

        {
            // TODO: Add your initialization logic here
            player = new Sprite();
            enemy = new Sprite();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player.Texture = Content.Load<Texture2D>("mario");
            player.Rect = new Rectangle(100, 100, 100, 150);
            enemy.Texture = Content.Load<Texture2D>("traktor2");
            enemy.Rect = new Rectangle(270, 200, 170, 150);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            enemy.Rect=new Rectangle(enemy.Rect.X-1, enemy.Rect.Y, enemy.Rect.Width, enemy.Rect.Y);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(player.Texture, player.Rect, Color.White);
            _spriteBatch.Draw(enemy.Texture, enemy.Rect, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
