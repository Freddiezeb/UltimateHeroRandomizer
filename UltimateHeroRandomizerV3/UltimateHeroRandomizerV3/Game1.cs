using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        ChooseGame gameChoose;
        SelectionRectangle[] selectionRects;

        ChampionManager champManager;
        ButtonManager buttonManager;
        FilterManager filterManager;

        Texture2D selectTex;

        Rectangle buttonRect, selectRect, resetRect;

        bool visible = false;

        bool filterCreated;

        Random rnd;

        Form gameForm;

        Submenu submenu;

        public static SpriteFont font;

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
            gameForm = Control.FromHandle(this.Window.Handle) as Form;

            this.Window.Position = new Point(250, 50);
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


            IsMouseVisible = true;


            filterManager = new FilterManager(TextureManager.filterButton);

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
        }


        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //    Exit();
            KeyMouseReader.Update();
            buttonManager.ButtonUpdate(KeyMouseReader.mouseState);

            if (KeyMouseReader.KeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                submenu = new Submenu(ref gameChoose);
                submenu.Show();
                gameForm.Hide();
            }

            if (!filterCreated)
            {
                champManager.ChampionSelected(Content, gameTime);
                foreach (SelectionRectangle rect in selectionRects)
                {
                    if (rect.rectangle.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
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
            }

            if (filterManager.reset)
            {
                champManager.ResetFilter();
            }




            filterManager.FilterMarker();
            champManager.GetChampionRole();
            champManager.FilterChampions(ref filterManager);



            if (buttonManager.createFilter)
            {
                champManager.CreateChampionFilter();
                for (int i = 0; i < selectionRects.Length; i++)
                {
                    selectionRects[i].visible = false;
                }
                buttonManager.createFilter = false;
                filterCreated = true;
            }
            if (buttonManager.randomize)
            {
                if (filterCreated)
                {
                    champManager.RandomizeChampion(Window);
                }
                else
                {
                    champManager.RandomizeAllChampions(Window);
                }

                buttonManager.randomize = false;
            }
            if (buttonManager.restoreFilter)
            {
                champManager.ResetFilter();
                buttonManager.restoreFilter = false;
                filterCreated = false;
            }

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

            filterManager.DrawBoxes(spriteBatch);

            buttonManager.Draw(spriteBatch);
            champManager.DrawChampName(spriteBatch);


            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
