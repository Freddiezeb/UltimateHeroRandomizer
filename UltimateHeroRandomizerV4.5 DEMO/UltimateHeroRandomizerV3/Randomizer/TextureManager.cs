using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class TextureManager
    {
        public static Texture2D championCollage;
        public static Texture2D buttonTexture;
        public static Texture2D buttonNeutral;
        public static Texture2D backgroundTexture;
        public static Texture2D filterButton;
        public static SpriteFont buttonFont;

        public static void LoadTextures(ContentManager Content)
        {
            championCollage = Content.Load<Texture2D>("COMPLETECOLLAGE");
            buttonTexture = Content.Load<Texture2D>("buttonWhite");
            buttonNeutral = Content.Load<Texture2D>("buttonNeutral");
            backgroundTexture = Content.Load<Texture2D>("black_background");
            filterButton = Content.Load<Texture2D>("radioButton");

            buttonFont = Content.Load<SpriteFont>("buttonFont");

        }
    }
}
