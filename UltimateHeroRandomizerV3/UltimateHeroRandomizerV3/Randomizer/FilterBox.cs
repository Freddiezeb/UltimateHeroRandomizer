using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class FilterBox
    {
        Texture2D texture;
        public Rectangle rectangle;

        public bool marked;

        public FilterBox(Texture2D texture, Rectangle rectangle, ref bool marked)
        {
            this.texture = texture;
            this.rectangle = rectangle;
            this.marked = marked;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (marked)
            {
                spriteBatch.Draw(texture, rectangle, Color.Black);
            }
            else
            {
                spriteBatch.Draw(texture, rectangle, Color.White);
            }

        }
    }
}
