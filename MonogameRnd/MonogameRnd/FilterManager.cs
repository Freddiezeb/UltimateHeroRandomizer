using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class FilterManager
    {
        FilterBox[] filterBoxes;

        Rectangle rectangle;
        Texture2D texture;

        bool marked;

        public bool assassin, marksman, mage, tank, fighter;

        public FilterManager(Texture2D texture)
        {
            filterBoxes = new FilterBox[5];

            for (int i = 0; i < filterBoxes.Length; i++)
            {
                rectangle = new Rectangle(20, 200 + i * 60, 20, 20);
                filterBoxes[i] = new FilterBox(texture, rectangle, ref marked);    
            }



        }

        public void FilterMarker()
        {
            for (int i = 0; i < filterBoxes.Length; i++)
            {
                if (filterBoxes[i].rectangle.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y) && KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    if (!filterBoxes[i].marked)
                    {
                        filterBoxes[i].marked = true;
                    }
                    else
                    {
                        filterBoxes[i].marked = false;
                    }
                }
            }

            if (filterBoxes[0].marked)
            {
                marksman = true;
            }
        }

        public void DrawBoxes(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < filterBoxes.Length; i++)
            {
                filterBoxes[i].Draw(spriteBatch);
            }

            spriteBatch.DrawString(Game1.font, "Marksman", new Vector2(50, 199), Color.White);
            spriteBatch.DrawString(Game1.font, "Mage", new Vector2(50, 259), Color.White);
            spriteBatch.DrawString(Game1.font, "Assassin", new Vector2(50, 318), Color.White);
            spriteBatch.DrawString(Game1.font, "Fighter", new Vector2(50, 378), Color.White);
            spriteBatch.DrawString(Game1.font, "Tank", new Vector2(50, 438), Color.White);

        }
    }
}
