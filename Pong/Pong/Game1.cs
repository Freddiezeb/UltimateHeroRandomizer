using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Bollen
        Texture2D BollSprite;
        //Plattformen
        Texture2D PlatformSprite; 
        
        //Hastigheten och Position för bollen
        Vector2 BollPosition = Vector2.Zero;
        Vector2 BollSpeed = new Vector2(150, 150);
        //Position för plattformen
        Vector2 PlatformPosition;
        

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            base.Initialize();

            //Sätter position för plattformen
            PlatformPosition = new Vector2(
            graphics.GraphicsDevice.Viewport.Width / 2 - PlatformSprite.Width / 2,
            graphics.GraphicsDevice.Viewport.Height - PlatformSprite.Height);
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            //Texturer
            BollSprite = Content.Load<Texture2D>("Bilder/PongBoll");
            PlatformSprite = Content.Load<Texture2D>("Bilder/PongPlatta");
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Bollen rör sig av hastigheten/sekunder
            BollPosition += BollSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            int maxX = GraphicsDevice.Viewport.Width - BollSprite.Width;
            int maxY = GraphicsDevice.Viewport.Height - BollSprite.Height;

            //Få bollen att studsa och resetta när den hamnar längst ner
            if (BollPosition.X > maxX || BollPosition.X < 0)
                BollSpeed.X *= -1;
            if (BollPosition.Y > maxY || BollPosition.Y < 0)
                BollSpeed.Y *= -1;
            else if (BollPosition.Y > maxY)
            {
                BollPosition.Y = 0;
                BollSpeed.X = 150;
                BollSpeed.Y = 150;
            }

            //Få bollen och plattform att kollidera
            Rectangle BollRect =
                new Rectangle((int)BollPosition.X, (int)BollPosition.Y,
                    BollSprite.Width, BollSprite.Height);

            Rectangle PlatformRect =
                new Rectangle((int)PlatformPosition.X, (int)PlatformPosition.Y,
                   PlatformSprite.Width, PlatformSprite.Height);

           //öka hastigheten på bollen om den rör plattformen
            if (BollRect.Intersects(PlatformRect))
            {
                BollSpeed.Y += 50;
                if (BollSpeed.X < 0)
                    BollSpeed.X -= 50;
                else
                    BollSpeed.X += 50;
                //skicka upp bollen om den ramlar
                BollSpeed.Y *= -1; 
            }



            //Uppdatera/Göra så att man kan röra på plattformen
            KeyboardState keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Right))
                PlatformPosition.X += 5;
            else if (keyState.IsKeyDown(Keys.Left))
                PlatformPosition.X -= 5;

         

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

           //Ritar ut bollen och dens position
            spriteBatch.Draw(BollSprite, BollPosition, Color.White);
            //Ritar ut plattformen och dens position
            spriteBatch.Draw(PlatformSprite, PlatformPosition, Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
