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
    public enum RandomizerMode
    {
        RandomizeWithAll,
        RandomizePersonalFilter,
        RandomizePremadeFilter
    }

    class RandomizerManager
    {
        SelectionRectangle[] selectionRects;

        ChampionManager champManager;
        ButtonManager buttonManager;
        FilterManager filterManager;

        RandomizerMode randomizerMode = RandomizerMode.RandomizeWithAll;

        Texture2D selectTex;

        Rectangle selectRect;

        bool visible = false;

        public static SpriteFont font;

        int x = 0, y = 200;


        public void LoadContent(ContentManager Content)
        {
            TextureManager.LoadTextures(Content);

            font = Content.Load<SpriteFont>("myFont");
            selectTex = Content.Load<Texture2D>("Transparent");

            filterManager = new FilterManager(TextureManager.filterButton);

            buttonManager = new ButtonManager(TextureManager.buttonNeutral);
            buttonManager.LoadButtons();

            champManager = new ChampionManager();
            champManager.LoadChampions(Content);

            selectionRects = new SelectionRectangle[130];

            for (int i = 0; i < selectionRects.Length; i++)
            {
                selectRect = new Rectangle(y, x, 75, 75);

                selectionRects[i] = new SelectionRectangle(selectTex, selectRect, visible);
                y += 75;
                if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
                {
                    y = 200;
                    x += 75;
                }
            }
        }

        public void Update(GameTime gameTime, GameWindow Window, ContentManager Content)
        {
            //KeyMouseReader.Update();
            buttonManager.ButtonUpdate(KeyMouseReader.mouseState);

            if (filterManager.clicked)
            {
                randomizerMode = RandomizerMode.RandomizePremadeFilter;
            }
            if (buttonManager.createFilter && !filterManager.filterMarked)
            {
                randomizerMode = RandomizerMode.RandomizePersonalFilter;
            }
            if (buttonManager.restoreFilter)
            {
                randomizerMode = RandomizerMode.RandomizeWithAll;
                filterManager.UnmarkFilters();              
                filterManager.clicked = false;
                filterManager.filterMarked = false;
            }


            switch (randomizerMode)
            {
                case RandomizerMode.RandomizeWithAll:
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

                    if (buttonManager.randomize)
                    {
                        champManager.RandomizeAllChampions(Window, Content);
                        buttonManager.randomize = false;
                    }

                    if (buttonManager.restoreFilter)
                    {
                        champManager.ResetFilter();
                        for (int i = 0; i < selectionRects.Length; i++)
                        {
                            selectionRects[i].visible = false;
                        }
                        buttonManager.restoreFilter = false;
                    }
                    break;

                case RandomizerMode.RandomizePersonalFilter:

                    if (buttonManager.createFilter)
                    {
                        champManager.CreateChampionFilter();
                        buttonManager.createFilter = false;
                    }

                    for (int i = 0; i < selectionRects.Length; i++)
                    {
                        selectionRects[i].visible = false;
                        if (i > selectionRects.Length)
                        {
                            break;
                        }
                    }

                    if (buttonManager.randomize)
                    {
                        champManager.RandomizeChampion(Window, Content);
                        buttonManager.randomize = false;
                    }

                    if (buttonManager.restoreFilter)
                    {
                        champManager.ResetFilter();
                        buttonManager.restoreFilter = false;
                        buttonManager.createFilter = false;
                    }
                    break;

                case RandomizerMode.RandomizePremadeFilter:

                    if (filterManager.clicked)
                    {
                        champManager.FilterChampions(ref filterManager);
                        filterManager.clicked = false;
                        for (int i = 0; i < selectionRects.Length; i++)
                        {
                            selectionRects[i].visible = false;
                        }

                    }
                    if (buttonManager.randomize)
                    {
                        champManager.RandomizeChampion(Window, Content);
                        buttonManager.randomize = false;
                    }

                    if (buttonManager.restoreFilter)
                    {
                        champManager.ResetFilter();
                        buttonManager.restoreFilter = false;
                        buttonManager.createFilter = false;


                    }

                    if (filterManager.reset)
                    {
                        buttonManager.restoreFilter = true;
                        champManager.ResetFilter();
                        filterManager.reset = false;
                    }

                    break;
                default:
                    break;
                    
            }     

            champManager.GetChampionRole();
            filterManager.FilterMarker();
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

