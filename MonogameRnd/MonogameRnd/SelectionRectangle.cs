using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class SelectionRectangle
    {

        Texture2D texture;
        public Rectangle rectangle;

        public bool visible;

        public SelectionRectangle(Texture2D texture, Rectangle rectangle, bool visible)
        {
            this.texture = texture;
            this.rectangle = rectangle;
            this.visible = visible;
        }

        public void DrawRect(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
