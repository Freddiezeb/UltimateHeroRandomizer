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

        float volume = 0.1f;

        string name;
        bool selected;

        string championName = "";
        string roleName = "";

        SoundManager soundManager;
        ChampionInfo championInfo;

        SoundEffectInstance pastInstance;
        SoundEffectInstance soundEffectInstance;

        Random rnd = new Random();

        public int pastIndex;
        int role1Index, role2Index, role3Index, role4Index, role5Index, role6Index;

        bool randomized;
        string role;


        int sourceSize;
        int arraySize;

        Texture2D collageTexture;

        SoundEffect selectionSound;

        Rectangle keepRectangleInfo;

        public ChampionManager()
        {

            if (Submenu.Dota)
            {
                arraySize = 110;
                sourceSize = 80;
                collageTexture = TextureManager.dotaCollage;
                role1Index = 2;
                role2Index = 0;
                role3Index = 10;
                role4Index = 4;
                role5Index = 6;
                role6Index = 14;
            }

            if (Submenu.League)
            {
                arraySize = 130;
                sourceSize = 100;
                collageTexture = TextureManager.championCollage;
                role1Index = 7;
                role2Index = 1;
                role3Index = 2;
                role4Index = 0;
                role5Index = 3;
                role6Index = 10;
            }

            soundManager = new SoundManager();
            championInfo = new ChampionInfo();
            champions = new Champion[arraySize];
        }

        public void LoadChampions(ContentManager Content)
        {
            // Skapar alla champions

            keepRectangleInfo = new Rectangle(200, 0, 75, 75);

            for (int i = 0; i < champions.Length; i++)
            {
                destRect = new Rectangle(destX, destY, 75, 75);
                sourceRect = new Rectangle(sourceX, sourceY, sourceSize, sourceSize);

                champions[i] = new Champion(collageTexture, destRect, sourceRect, ref name, ref selected, ref selectionSound, ref role, ref randomized);
                destX += 75;
                sourceX += sourceSize;
                if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
                {
                    destX = 200;
                    destY += 75;
                    sourceX = 0;
                    sourceY += sourceSize;
                }
            }
            soundManager.LoadSounds(ref champions, Content);
        }

        public void ChampionSelected(ContentManager Content, GameTime gameTime)
        {
            //Metod som bestämmer om en champion är selected eller inte. Visar namn på den karaktär som blir tryckt på. 

            foreach (Champion c in champions)
            {
                if (c.destRect.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    if (!c.selected)
                    {
                        //c.selectionSound.Play(0.01f, 0, 0);
                        c.selected = true;

                        championName = c.name;

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

        public void RandomizeChampion(GameWindow Window, ContentManager Content)
        {
            //Metod som slumpar en champion som har blivit vald(Selected). Den Hamnar i mitten av fönstret, den skalas upp och det spelas ett selection sound som tillhör karaktären. 
            soundManager.LoadSounds(ref champions, Content);

            for (int i = 0; i < champions.Length; i++)
            {

                i = rnd.Next(0, arraySize);

                if (champions[i].selected)
                {
                    champions[pastIndex].destRect = keepRectangleInfo;
                    keepRectangleInfo = champions[i].destRect;
                    if (pastInstance != null)
                    {
                        pastInstance.Pause();
                    }
                    pastIndex = i;

                    if (champions[pastIndex].selectionSound != null)
                    {
                        pastInstance = champions[pastIndex].selectionSound.CreateInstance();
                    }
                    if (champions[i].selectionSound != null)
                    {
                        soundEffectInstance = champions[i].selectionSound.CreateInstance();
                        pastInstance = soundEffectInstance;
                        soundEffectInstance.Volume = volume;
                        soundEffectInstance.Play();
                    }


                    champions[i].destRect = new Rectangle(40, 40, 125, 125);
                    champions[i].selected = false;
                    roleName = champions[i].role;
                    championName = champions[i].name;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public void RandomizeAllChampions(GameWindow Window, ContentManager Content)
        {
            soundManager.LoadSounds(ref champions, Content);
            //Slumpa mellan alla karaktärer som finns
            int i;

            i = rnd.Next(0, arraySize);

            champions[pastIndex].destRect = keepRectangleInfo;
            
            keepRectangleInfo = champions[i].destRect;

            if (pastInstance != null)
            {
                pastInstance.Pause();
            }
            
            pastIndex = i;

            if (champions[pastIndex].selectionSound != null)
            {
                pastInstance = champions[pastIndex].selectionSound.CreateInstance();
            }
            if (champions[i].selectionSound != null)
            {
                soundEffectInstance = champions[i].selectionSound.CreateInstance();
                pastInstance = soundEffectInstance;
                soundEffectInstance.Volume = volume;
                soundEffectInstance.Play();
            }

            champions[i].destRect = new Rectangle(40, 40, 125, 125);
            championName = champions[i].name;
            roleName = champions[i].role;
        }


        public void CreateChampionFilter()
        {
            // Skapar ett filter för alla champions som blivit valda(Selected) // UNDER CONSTRUCTION

            championName = "";
            roleName = "";

            int nr = 0;
            destX = 200;
            destY = 0;

            keepRectangleInfo = new Rectangle(-600, 0, 75, 75);

            for (int i = 0; i < champions.Length; i++)
            {
                if (champions[i].selected)
                {
                    champions[i].destRect = new Rectangle(destX, destY, 75, 75);
                    destX += 75;
                    nr++;
                    if (nr == 10 || nr == 20 || nr == 30 || nr == 40 || nr == 50) //Skapar rader för 10st i X-led när man skapar filter
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

            //Återskapar ursprungsfiltret där alla karaktärer finns med.

            pastIndex = 0;
            keepRectangleInfo = new Rectangle(200, 0, 75, 75);

            championName = "";
            roleName = "";

            destX = 200;
            destY = 0;
            sourceX = 0;
            sourceY = 0;
            for (int i = 0; i < champions.Length; i++)
            {
                destRect = new Rectangle(destX, destY, 75, 75);

                sourceRect = new Rectangle(sourceX, sourceY, sourceSize, sourceSize);

                champions[i] = new Champion(collageTexture, destRect, sourceRect, ref name, ref selected, ref selectionSound, ref role, ref randomized);
                destX += 75;
                sourceX += sourceSize;
                if (i == 12 || i == 25 || i == 38 || i == 51 || i == 64 || i == 77 || i == 90 || i == 103 || i == 116)
                {
                    destX = 200;
                    destY += 75;
                    sourceX = 0;
                    sourceY += sourceSize;
                }

            }
        }

        public void DrawChampions(SpriteBatch spriteBatch)
        {
            //Ritar ut alla karaktärer
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
            //Ritar ut namnet på vald champion.
            spriteBatch.DrawString(RandomizerManager.font, championName, new Vector2(40, 170), Color.White);
            spriteBatch.DrawString(RandomizerManager.font, roleName, new Vector2(40, 200), Color.White);
        }

        public void FilterChampions(ref FilterManager filterManager)
        {
            //Håller koll på vilket förskapat filter som används. UNDER CONSTRUCTION
            destX = 200;
            destY = 0;

            championName = "";
            roleName = "";
            keepRectangleInfo = new Rectangle(200, 0, 75, 75);

            int nr = 0;

            for (int i = 0; i < champions.Length; i++)
            {
                champions[i].selected = false;
                if (filterManager.marksman)
                {

                    if (champions[i].role == "Marksman" || champions[i].role == "Carry")
                    {
                        pastIndex = role1Index;
                        champions[i].selected = true;
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
                if (filterManager.mage)
                {
                    if (champions[i].role == "Mage" || champions[i].role == "Disabler")
                    {
                        pastIndex = role2Index;
                        champions[i].selected = true;
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

                if (filterManager.assassin)
                {
                    if (champions[i].role == "Assassin" || champions[i].role == "Nuker")
                    {
                        pastIndex = role3Index;
                        champions[i].selected = true;
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

                if (filterManager.fighter)
                {
                    if (champions[i].role == "Fighter" || champions[i].role == "Pusher")
                    {
                        pastIndex = role4Index;
                        champions[i].selected = true;
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

                if (filterManager.tank)
                {
                    if (champions[i].role == "Tank" || champions[i].role == "Initiator")
                    {
                        pastIndex = role5Index;
                        champions[i].selected = true;
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

                if (filterManager.support)
                {
                    if (champions[i].role == "Support")
                    {
                        pastIndex = role6Index;
                        champions[i].selected = true;
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
