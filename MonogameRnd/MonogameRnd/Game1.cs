using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;


namespace MonogameRnd
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Champion[] champions;
        SelectionRectangle[] selectionRects;

        ChampionManager champManager;
        ButtonManager buttonManager;

        Rectangle sourceRect;
        Rectangle destRect;
        Texture2D championTex, button, selectTex, background;

        Rectangle buttonRect, selectRect, resetRect;
        GameWindow gameWindow;

        SoundEffect selectionSound;

        string name;
        string leName;


        //MonoGameEx monogameEx;

        bool selected;
        bool clickedYet;
        bool visible = false;

        double timer;

        Random rnd;


        bool startTimer;

        public static SpriteFont font;

        int selectedChampions = 0;

        int x = 200, y = 0;

        int z = 0, w = 200;

        int l = 0, b = 0;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {

            this.Window.Position = new Point(250,75);
            graphics.PreferredBackBufferHeight = 900;
            graphics.PreferredBackBufferWidth = 1175;
            graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            TextureManager.LoadTextures(Content);

            font = Content.Load<SpriteFont>("myFont");
            selectTex = Content.Load<Texture2D>("Transparent");

            
            //champions = new Champion[130];

            IsMouseVisible = true;
            clickedYet = false;

            leName = "";

            buttonManager = new ButtonManager(TextureManager.buttonTexture);
            buttonManager.LoadButtons();

            champManager = new ChampionManager();
            champManager.LoadChampions(Content);



            rnd = new Random();


            buttonRect = new Rectangle(600, 800, TextureManager.buttonTexture.Width, TextureManager.buttonTexture.Height);
            resetRect = new Rectangle(800, 800, TextureManager.buttonTexture.Width, TextureManager.buttonTexture.Height);

            selectionRects = new SelectionRectangle[130];

            for (int i = 0; i < selectionRects.Length; i++)
            {
                selectRect = new Rectangle(w, z, 75, 75);

                selectionRects[i] = new SelectionRectangle(selectTex, selectRect, visible);
                w += 75;
                if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
                {
                    w = 200;
                    z += 75;
                }
            }

            //var form = (System.Windows.Forms.Form)System.Windows.Forms.Control.FromHandle(this.Window.Handle);
            //form.Location = new System.Drawing.Point(0, 0);
        }

        //public void NextLine()
        //{
        //    if()
        //}




        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyMouseReader.Update();

            buttonManager.ButtonUpdate(KeyMouseReader.mouseState);
            champManager.ChampionSelected();

            foreach (SelectionRectangle rect in selectionRects)
            {
                if (rect.rectangle.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    if (!rect.visible)
                    {
                        rect.visible = true;
                    }
                    else
                    {
                        rect.visible = false;
                    }
                }
            }

            if (KeyMouseReader.KeyPressed(Keys.Space))
            {
                for (int i = 0; i < champions.Length; i++)
                {
                    i = rnd.Next(0, 130);

                    if (champions[i].selected)
                    {
                        champions[i].destRect = new Rectangle(Window.ClientBounds.Width/2 - 100, Window.ClientBounds.Height/2 - 100, 200, 200);
                        champions[i].selected = false;
                        break;
                    }


                }
            }

            if (buttonManager.createFilter)
            {
                champManager.CreateChampionFilter();
                for (int i = 0; i < selectionRects.Length; i++)
                {
                    selectionRects[i].visible = false;
                }
                buttonManager.createFilter = false;
            }
            if (buttonManager.randomize)
            {
                champManager.RandomizeChampion(Window);
                buttonManager.randomize = false;
            }
            if (buttonManager.restoreFilter)
            {
                champManager.ResetFilter();
                buttonManager.restoreFilter = false;
            }

            //if (buttonRect.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed)
            //{

            //    champManager.CreateChampionFilter();

            //    for (int i = 0; i < selectionRects.Length; i++)
            //    {
            //        selectionRects[i].visible = false;
            //    }

            //}

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            spriteBatch.Draw(TextureManager.backgroundTexture, Vector2.Zero, Color.White);

            champManager.DrawChampions(spriteBatch);

            for (int i = 0; i < selectionRects.Length; i++)
            {
                if (selectionRects[i].visible)
                {
                    selectionRects[i].DrawRect(spriteBatch);
                }

            }

            buttonManager.Draw(spriteBatch);

            //spriteBatch.Draw(TextureManager.buttonTexture, buttonRect, Color.White);
            //spriteBatch.Draw(TextureManager.buttonTexture, resetRect, Color.White);

            //spriteBatch.DrawString(font, leName, new Vector2(600, 0), Color.White);

            //spriteBatch.DrawString(font, "Create Filter", new Vector2(buttonRect.X + buttonRect.Width /4, buttonRect.Y + buttonRect.Height / 3), Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }

        //void ResetFilter()
        //{
        //    x = 200;
        //    y = 0;
        //    l = 0;
        //    b = 0;
        //    for (int i = 0; i < champions.Length; i++)
        //    {
        //        destRect = new Rectangle(x, y, 75, 75);

        //        sourceRect = new Rectangle(l, b, 100, 100);

        //        champions[i] = new Champion(TextureManager.championCollage, destRect, sourceRect, ref name, ref selected);
        //        x += 75;
        //        l += 100;
        //        if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
        //        {
        //            x = 200;
        //            y += 75;
        //            l = 0;
        //            b += 100;
        //        }

        //    }
        //}




    }
}
