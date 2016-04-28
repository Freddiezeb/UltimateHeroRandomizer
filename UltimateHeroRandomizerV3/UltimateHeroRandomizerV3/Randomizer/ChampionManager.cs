using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{

    class ChampionManager
    {
        Champion[] champions;

        Rectangle destRect, sourceRect;

        int destX = 200;
        int destY = 0;

        int sourceX = 0;
        int sourceY = 0;

        float volume = 0.2f;

        string name;
        bool selected;

        string THISNAME = "";
        string roleName = "";

        SoundManager soundManager;
        ChampionInfo championInfo;

        bool soundPlaying;

        Random rnd = new Random();

        bool timerstart;

        int pastIndex;

        bool randomized;
        string role;


        SoundEffect selectionSound;

        Rectangle keepRectangleInfo;

        public ChampionManager()
        {
            champions = new Champion[130];

            soundManager = new SoundManager();
            championInfo = new ChampionInfo();
        }

        public void LoadChampions(ContentManager Content)
        {

            for (int i = 0; i < champions.Length; i++)
            {
                destRect = new Rectangle(destX, destY, 75, 75);
                sourceRect = new Rectangle(sourceX, sourceY, 100, 100);

                champions[i] = new Champion(TextureManager.championCollage, destRect, sourceRect, ref name, ref selected, ref selectionSound, role, ref randomized);
                destX += 75;
                sourceX += 100;
                if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
                {
                    destX = 200;
                    destY += 75;
                    sourceX = 0;
                    sourceY += 100;
                }

            }

            soundManager.LoadSounds(ref champions, Content);
        }

        public void ChampionSelected(ContentManager Content, GameTime gameTime)
        {
            foreach (Champion c in champions)
            {

                if (c.destRect.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    if (!c.selected)
                    {
                        //c.selectionSound.Play(0.01f, 0, 0);
                        c.selected = true;

                        THISNAME = c.name;

                        if (c.role != null)
                        {
                            roleName = c.role;
                        }


                    }
                    else
                    {
                        c.selected = false;
                    }
                }


            }


            soundManager.LoadSounds(ref champions, Content);
        }

        public void RandomizeChampion(GameWindow Window)
        {
            for (int i = 0; i < champions.Length; i++)
            {

                i = rnd.Next(0, 130);


                if (champions[i].selected)
                {
                    champions[pastIndex].destRect = keepRectangleInfo;
                    keepRectangleInfo = champions[i].destRect;
                    pastIndex = i;

                    champions[i].destRect = new Rectangle(Window.ClientBounds.Width / 2 - 100, Window.ClientBounds.Height / 2 - 100, 200, 200);
                    champions[i].selected = false;
                    champions[i].selectionSound.Play();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void RandomizeAllChampions(GameWindow Window)
        {
            for (int i = 0; i < champions.Length; i++)
            {
                i = rnd.Next(0, 130);
                champions[i].destRect = new Rectangle(Window.ClientBounds.Width / 2 - 100, Window.ClientBounds.Height / 2 - 100, 200, 200);
                champions[i].selectionSound.Play();
                break;
            }
        }

        public void CreateChampionFilter()
        {


            int nr = 0;
            for (int i = 0; i < champions.Length; i++)
            {
                if (champions[i].selected)
                {
                    champions[i].destRect = new Rectangle(destX, destY, 75, 75);
                    destX += 75;
                    nr++;
                    if (nr == 10 || nr == 20 || nr == 30 || nr == 40 || nr == 50)
                    {
                        destX = 200;
                        destY += 75;
                    }
                }
                if (!champions[i].selected)
                {
                    champions[i].destRect = new Rectangle(1000, 1000, 0, 0);
                }
            }
        }

        public void ResetFilter()
        {
            destX = 200;
            destY = 0;
            sourceX = 0;
            sourceY = 0;
            for (int i = 0; i < champions.Length; i++)
            {
                destRect = new Rectangle(destX, destY, 75, 75);

                sourceRect = new Rectangle(sourceX, sourceY, 100, 100);

                champions[i] = new Champion(TextureManager.championCollage, destRect, sourceRect, ref name, ref selected, ref selectionSound, role, ref randomized);
                destX += 75;
                sourceX += 100;
                if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
                {
                    destX = 200;
                    destY += 75;
                    sourceX = 0;
                    sourceY += 100;
                }

            }
        }

        public void DrawChampions(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < champions.Length; i++)
            {
                champions[i].DrawChamps(spriteBatch);

                if (champions[i].selected)
                {
                    champions[i].DrawChamps(spriteBatch);
                }
            }
        }


        public void GetChampionRole()
        {
            championInfo.GetChampionInfo(ref champions);
        }


        public void DrawChampName(SpriteBatch spriteBatch)
        {

            spriteBatch.DrawString(Game1.font, THISNAME, Vector2.Zero, Color.Black);

            spriteBatch.DrawString(Game1.font, roleName, new Vector2(0, 100), Color.White);
        }

        public void FilterChampions(ref FilterManager filterManager)
        {

            destX = 200;
            destY = 0;
            int nr = 0;
            for (int i = 0; i < champions.Length; i++)
            {
                if (filterManager.marksman)
                {
                    if (champions[i].role == "Marksman")
                    {
                        champions[i].destRect = new Rectangle(destX, destY, 75, 75);
                        destX += 75;
                        nr++;
                        if (nr == 10 || nr == 20 || nr == 30 || nr == 40 || nr == 50)
                        {
                            destX = 200;
                            destY += 75;
                        }

                    }

                    else
                    {
                        champions[i].destRect = new Rectangle(1000, 1000, 75, 75);
                    }
                }



            }

        }

    }
}
