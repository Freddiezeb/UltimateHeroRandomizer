using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class TextureManager
    {
        public static Texture2D championCollage;
        public static Texture2D buttonTexture;
        public static Texture2D backgroundTexture;


        public static void LoadTextures(ContentManager Content)
        {
            championCollage = Content.Load<Texture2D>("COMPLETECOLLAGE");
            buttonTexture = Content.Load<Texture2D>("Button");
            backgroundTexture = Content.Load<Texture2D>("backgroundProject");

        }
    }
}
