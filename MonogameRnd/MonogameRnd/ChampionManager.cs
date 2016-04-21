using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
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



        SoundManager soundManager;

        bool soundPlaying;

        Random rnd = new Random();

        bool timerstart;

        int pastIndex;

        bool randomized;
        int role;


        SoundEffect selectionSound;

        Rectangle keepRectangleInfo;

        public ChampionManager()
        {
            champions = new Champion[130];

            soundManager = new SoundManager();


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
                    }
                    else
                    {
                        c.selected = false;
                    }
                }


            }

            //if (timerstart)
            //{
            //    timer = gameTime.ElapsedGameTime.Milliseconds;
            //}
            //if (soundPlaying && timer > 100)
            //{
            //    soundPlaying = false;
            //    timerstart = false;
            //    timer = 0;
            //}

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

        public void GetChampionName()
        {
            champions[0].name = "Aatrox";
            champions[1].name = "Ahri";
            champions[2].name = "Akali";
            champions[3].name = "Alistar";
            champions[4].name = "Amumu";
            champions[5].name = "Anivia";
            champions[6].name = "Annie";
            champions[7].name = "Ashe";
            champions[8].name = "Azir";
            champions[9].name = "Bard";
            champions[10].name = "Blitzcrank";
            champions[11].name = "Brand";
            champions[12].name = "Braum";
            champions[13].name = "Caitlyn";
            champions[14].name = "Cassiopeia";
            champions[15].name = "Cho Gath";
            champions[16].name = "Corki";
            champions[17].name = "Darius";
            champions[18].name = "Diana";
            champions[19].name = "Draven";
            champions[20].name = "Dr. Mundo";
            champions[21].name = "Ekko";
            champions[22].name = "Elise";
            champions[23].name = "Evelynn";
            champions[24].name = "Ezreal";
            champions[25].name = "Fiddlesticks";
            champions[26].name = "Fiora";
            champions[27].name = "Fizz";
            champions[28].name = "Galio";
            champions[29].name = "Gangplank";
            champions[30].name = "Garen";
            champions[31].name = "Gnar";
            champions[32].name = "Gragas";
            champions[33].name = "Graves";
            champions[34].name = "Hecarim";
            champions[35].name = "Heimerdinger";

        }

        public void GetChampionRole()
        {
            //Roles:
            //1 = Marksman
            //2 = Mage
            //3 = Assassin
            //4 = Fighter
            //5 = Tank

            champions[0].role = 1;
            champions[1].role = 1;
            champions[2].role = 1;
            champions[3].role = 1;
            champions[4].role = 1;
            champions[5].role = 1;
            champions[6].role = 1;
            champions[7].role = 1;
            champions[8].role = 1;
            champions[9].role = 1;

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
                    if (champions[i].role == 1)
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

        //public void SelectionSound(ContentManager Content)
        //{
        //    champions[0].selectionSound = Content.Load<SoundEffect>("Aatrox");
        //}
    }
}
