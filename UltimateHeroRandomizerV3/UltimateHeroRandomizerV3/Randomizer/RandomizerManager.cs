using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
    class RandomizerManager
    {
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

        //Form gameForm;

        Submenu submenu;

        public static SpriteFont font;

        int x = 200, y = 0;

        int z = 0, w = 200;

        int l = 0, b = 0;

        public void LoadContent(ContentManager Content)
        {
            TextureManager.LoadTextures(Content);

            font = Content.Load<SpriteFont>("myFont");
            selectTex = Content.Load<Texture2D>("Transparent");





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

        public void Update(GameTime gameTime, GameWindow Window, ContentManager Content)
        {
            KeyMouseReader.Update();
            buttonManager.ButtonUpdate(KeyMouseReader.mouseState);



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
        }

        public void Draw(SpriteBatch spriteBatch)
        {
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

        }

    }
}

