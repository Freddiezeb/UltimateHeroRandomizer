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

            graphics.PreferredBackBufferHeight = 900;
            graphics.PreferredBackBufferWidth = 1175;
            graphics.ApplyChanges();


            this.Window.Position = new Point(gameForm.DesktopBounds.X / 2, gameForm.DesktopBounds.Y / 6);

            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            randomizerManager = new RandomizerManager();
            randomizerManager.LoadContent(Content);

            IsMouseVisible = true;
        }


        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            randomizerManager.Update(gameTime, Window, Content);

            if (ButtonManager.back)
            {
                if (Submenu.Dota)
                {
                    gameChoose = ChooseGame.Dota;
                }
                if (Submenu.League)
                {
                    gameChoose = ChooseGame.League;
                }
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

            randomizerManager.Draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
