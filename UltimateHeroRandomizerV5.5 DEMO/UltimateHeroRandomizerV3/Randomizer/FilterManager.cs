using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class FilterManager
    {
        FilterBox[] filterBoxes;

        Rectangle rectangle;

        bool marked;

        public bool reset, filterMarked, clicked;

        public bool assassin, marksman, mage, tank, fighter, support;

        public FilterManager(Texture2D texture)
        {
            //Skapar en box för varje karaktärstyp
            filterBoxes = new FilterBox[6];

            for (int i = 0; i < filterBoxes.Length; i++)
            {
                rectangle = new Rectangle(20, 250 + i * 60, 20, 20);
                filterBoxes[i] = new FilterBox(texture, rectangle, ref marked);
            }



        }

        public void FilterMarker()
        {
            //Markerar ett filter som bestämmer vilka och aktiverar en bool som säger vilken karaktärstyp som ska visas // UNDER CONSTRUCTION
            for (int i = 0; i < filterBoxes.Length; i++)
            {

                if (filterBoxes[i].rectangle.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    if (i == 0 && !filterBoxes[0].marked)
                    {
                        marksman = true;
                        mage = false;
                        tank = false;
                        fighter = false;
                        assassin = false;
                        support = false;
                        filterMarked = true;
                        clicked = true;

                        filterBoxes[0].marked = true;

                        filterBoxes[1].marked = false;
                        filterBoxes[2].marked = false;
                        filterBoxes[3].marked = false;
                        filterBoxes[4].marked = false;
                        filterBoxes[5].marked = false;
                        break;
                    }

                    if (i == 1 && !filterBoxes[1].marked)
                    {
                        mage = true;
                        marksman = false;
                        tank = false;
                        fighter = false;
                        assassin = false;
                        support = false;
                        filterMarked = true;
                        clicked = true;

                        filterBoxes[1].marked = true;

                        filterBoxes[0].marked = false;
                        filterBoxes[2].marked = false;
                        filterBoxes[3].marked = false;
                        filterBoxes[4].marked = false;
                        filterBoxes[5].marked = false;

                        break;
                    }
                    if (i == 2 && !filterBoxes[2].marked)
                    {
                        assassin = true;

                        mage = false;
                        marksman = false;
                        tank = false;
                        fighter = false;
                        support = false;
                        filterMarked = true;
                        clicked = true;

                        filterBoxes[2].marked = true;

                        filterBoxes[0].marked = false;
                        filterBoxes[1].marked = false;
                        filterBoxes[3].marked = false;
                        filterBoxes[4].marked = false;
                        filterBoxes[5].marked = false;
                        break;
                    }


                    if (i == 3 && !filterBoxes[3].marked)
                    {
                        fighter = true;

                        mage = false;
                        marksman = false;
                        tank = false;
                        assassin = false;
                        support = false;
                        filterMarked = true;
                        clicked = true;


                        filterBoxes[3].marked = true;

                        filterBoxes[0].marked = false;
                        filterBoxes[1].marked = false;
                        filterBoxes[2].marked = false;
                        filterBoxes[4].marked = false;
                        filterBoxes[5].marked = false;
                        break;
                    }

                    if (i == 4 && !filterBoxes[4].marked)
                    {
                        tank = true;

                        mage = false;
                        marksman = false;
                        fighter = false;
                        assassin = false;
                        support = false;
                        filterMarked = true;
                        clicked = true;

                        filterBoxes[4].marked = true;

                        filterBoxes[0].marked = false;
                        filterBoxes[1].marked = false;
                        filterBoxes[2].marked = false;
                        filterBoxes[3].marked = false;
                        filterBoxes[5].marked = false;
                        break;
                    }


                    if (i == 5 && !filterBoxes[5].marked)
                    {
                        support = true;

                        tank = false;
                        mage = false;
                        marksman = false;
                        fighter = false;
                        assassin = false;
                        filterMarked = true;
                        clicked = true;

                        filterBoxes[5].marked = true;

                        filterBoxes[0].marked = false;
                        filterBoxes[1].marked = false;
                        filterBoxes[2].marked = false;
                        filterBoxes[3].marked = false;
                        filterBoxes[4].marked = false;
                        break;
                    }

                    else
                    {
                        filterBoxes[i].marked = false;

                        reset = true;
                        filterMarked = false;

                        marksman = false;
                        mage = false;
                        assassin = false;
                        tank = false;
                        fighter = false;
                        support = false;
                        break;
                    }
                }
            }

        }

        public void DrawBoxes(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < filterBoxes.Length; i++)
            {
                filterBoxes[i].Draw(spriteBatch);
            }

            string box1 = null, box2 = null, box3 = null, box4 = null, box5 = null;

            if (Submenu.League)
            {
                box1 = "Marksman";
                box2 = "Mage";
                box3 = "Assassin";
                box4 = "Fighter";
                box5 = "Tank";
            }

            if (Submenu.Dota)
            {
                box1 = "Carry";
                box2 = "Disabler";
                box3 = "Nuker";
                box4 = "Pusher";
                box5 = "Initiator";
            }
            spriteBatch.DrawString(RandomizerManager.font, box1, new Vector2(50, 249), Color.White);
            spriteBatch.DrawString(RandomizerManager.font, box2, new Vector2(50, 309), Color.White);
            spriteBatch.DrawString(RandomizerManager.font, box3, new Vector2(50, 368), Color.White);
            spriteBatch.DrawString(RandomizerManager.font, box4, new Vector2(50, 428), Color.White);
            spriteBatch.DrawString(RandomizerManager.font, box5, new Vector2(50, 488), Color.White);
            spriteBatch.DrawString(RandomizerManager.font, "Support", new Vector2(50, 548), Color.White);

        }
    }
}
