using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateHeroRandomizerV3
{
    class PongManager
    {
        //GraphicsDeviceManager graphics;
        SpriteFont timeFont;

        //Bollen
        Texture2D BollSprite;
        //Plattformen
        Texture2D PlatformSprite;
        //Restart bilden
        Texture2D restartImage;
        Rectangle restartHitbox;

        //Hastigheten och Position för bollen
        Vector2 BollPosition = Vector2.Zero;
        Vector2 BollSpeed = new Vector2(150, 150);
        //Position för plattformen
        Vector2 PlatformPosition;

        double time = 20;
        int timetoString;
        int score = 0;

        enum States { startGame, Play, Restart }

        States states;

        MouseState mouseState, oldmouseState;

        public PongManager()
        {

        }


        public void LoadContent(ContentManager Content, GraphicsDeviceManager graphics)
        {
            //Texturer
            BollSprite = Content.Load<Texture2D>(@"Images/PongBoll");
            PlatformSprite = Content.Load<Texture2D>(@"Images/PongPlatta");
            restartImage = Content.Load<Texture2D>(@"Images/restart");
            timeFont = Content.Load<SpriteFont>(@"timeFont");

            states = States.Play;

                        PlatformPosition = new Vector2(
            graphics.GraphicsDevice.Viewport.Width / 2 - PlatformSprite.Width / 2,
            graphics.GraphicsDevice.Viewport.Height - PlatformSprite.Height);

        }



        public void Update(GameTime gameTime, GraphicsDeviceManager graphics)
        {

            oldmouseState = mouseState;
            mouseState = Mouse.GetState();

            switch (states)
            {
                case States.startGame:

                    break;

                case States.Play:
                    time -= gameTime.ElapsedGameTime.TotalSeconds;
                    timetoString = (int)time;

                    //Bollen rör sig av hastigheten/sekunder
                    BollPosition += BollSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;

                    int maxX = graphics.GraphicsDevice.Viewport.Width - BollSprite.Width;
                    int maxY = graphics.GraphicsDevice.Viewport.Height - BollSprite.Height;

                    //Få bollen att studsa och resetta när den hamnar längst ner
                    if (BollPosition.X > maxX || BollPosition.X < 0)
                        BollSpeed.X *= -1;
                    if (BollPosition.Y < 0)
                        BollSpeed.Y *= -1;
                    else if (BollPosition.Y > maxY)
                    {
                        states = States.Restart;
                    }

                    #region Boll och Platform kollision
                    //Få bollen och plattform att kollidera
                    Rectangle BollRect =
                        new Rectangle((int)BollPosition.X, (int)BollPosition.Y,
                            BollSprite.Width, BollSprite.Height);

                    Rectangle PlatformRect =
                        new Rectangle((int)PlatformPosition.X, (int)PlatformPosition.Y,
                           PlatformSprite.Width, PlatformSprite.Height);
                    #endregion

                    #region Bollens hastighet
                    //öka hastigheten på bollen om den rör plattformen
                    if (BollRect.Intersects(PlatformRect))
                    {
                        score += 10;
                        BollSpeed.Y += 50;
                        if (BollSpeed.X < 0)
                            BollSpeed.X -= 50;
                        else
                            BollSpeed.X += 50;
                        //skicka upp bollen om den ramlar
                        BollSpeed.Y *= -1;
                    }
                    #endregion

                    #region movePlatform
                    //Uppdatera/Göra så att man kan röra på plattformen
                    KeyboardState keyState = Keyboard.GetState();
                    if (keyState.IsKeyDown(Keys.Right))
                        PlatformPosition.X += 5;
                    else if (keyState.IsKeyDown(Keys.Left))
                        PlatformPosition.X -= 5;
                    #endregion
                    break;

                case States.Restart:
                    restartHitbox = new Rectangle(300, 230, 200, 50);

                    //Om man klickar på restartknappen så resettas alla värden och spelet börjar om
                    if (mouseState.LeftButton == ButtonState.Pressed && oldmouseState.LeftButton == ButtonState.Released
                        && restartHitbox.Contains(new Point(mouseState.X, mouseState.Y)))
                    {
                        time = 20;
                        score = 0;
                        BollPosition.Y = 0;
                        BollSpeed.X = 150;
                        BollSpeed.Y = 150;
                        states = States.Play;
                    }
                    break;
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {

            switch (states)
            {
                case States.startGame:

                    break;

                case States.Play:
                    //Ritar ut bollen och dens position
                    spriteBatch.DrawString(timeFont, "Time: " + timetoString.ToString(), new Vector2(10, 0), Color.Black);
                    spriteBatch.DrawString(timeFont, "Score: " + score.ToString(), new Vector2(650, 0), Color.Black);
                    spriteBatch.Draw(BollSprite, BollPosition, Color.White);
                    //Ritar ut plattformen och dens position
                    spriteBatch.Draw(PlatformSprite, PlatformPosition, Color.White);
                    break;

                case States.Restart:
                    //Ritar ut bollen och dens position
                    spriteBatch.DrawString(timeFont, "Time: " + timetoString.ToString(), new Vector2(10, 0), Color.Black);
                    spriteBatch.DrawString(timeFont, "Score: " + score.ToString(), new Vector2(650, 0), Color.Black);
                    spriteBatch.Draw(BollSprite, BollPosition, Color.White);
                    //Ritar ut plattformen och dens position
                    spriteBatch.Draw(PlatformSprite, PlatformPosition, Color.White);

                    spriteBatch.Draw(restartImage, new Vector2(300, 230), Color.White);
                    //spriteBatch.Draw(restartImage, restartHitbox, new Color(255, 255, 255, 20));
                    break;
            }


        }
    }
}