using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        ChooseGame gameChoose;

        RandomizerManager randomizerManager;
        PongManager pongManager;

        Form gameForm;

        Submenu submenu;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {

            gameForm = Control.FromHandle(this.Window.Handle) as Form;

            if (Submenu.Randomizer)
            {
                graphics.PreferredBackBufferHeight = 900;
                graphics.PreferredBackBufferWidth = 1175;
                graphics.ApplyChanges();

                this.Window.Position = new Point(gameForm.DesktopBounds.X / 2, gameForm.DesktopBounds.Y / 6);
            }

            if (Submenu.Pong)
            {
                graphics.PreferredBackBufferHeight = 480;
                graphics.PreferredBackBufferWidth = 800;
                graphics.ApplyChanges();

                this.Window.Position = new Point(gameForm.DesktopBounds.X / 2 +100 , gameForm.DesktopBounds.Y / 2);
            }



            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            if (Submenu.Pong)
            {
                pongManager = new PongManager();
                pongManager.LoadContent(Content, graphics);
            }

            if (Submenu.Randomizer)
            {
                randomizerManager = new RandomizerManager();
                randomizerManager.LoadContent(Content);
            }

            IsMouseVisible = true;
        }


        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {

            KeyMouseReader.Update();

            if (Submenu.Pong)
            {
                pongManager.Update(gameTime, graphics);
            }

            if (Submenu.Randomizer)
            {
                randomizerManager.Update(gameTime, Window, Content);
            }

            if (ButtonManager.back || Submenu.Pong == true && KeyMouseReader.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                if (Submenu.Dota)
                {
                    gameChoose = ChooseGame.Dota;
                }
                if (Submenu.League)
                {
                    gameChoose = ChooseGame.League;
                }
                Submenu.Pong = false;
                Submenu.Randomizer = false;
                ButtonManager.back = false;
                submenu = new Submenu(ref gameChoose);
                submenu.Show();
                gameForm.Hide();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            if (Submenu.Pong)
            {
                pongManager.Draw(spriteBatch);
            }

            if (Submenu.Randomizer)
            {
                randomizerManager.Draw(spriteBatch);
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
