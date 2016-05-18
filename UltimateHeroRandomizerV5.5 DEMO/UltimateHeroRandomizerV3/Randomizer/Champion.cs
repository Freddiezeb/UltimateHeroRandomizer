using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class Champion
    {

        Texture2D tex;
        public Rectangle destRect;
        Rectangle sourceRect;
        public string name;
        public SoundEffect selectionSound;

        public bool selected;
        public bool randomized;

        public string role;

        public Champion(Texture2D tex, Rectangle destRect, Rectangle sourceRect, ref string name, ref bool selected, ref SoundEffect selectionSound, ref string role, ref bool randomized)
        {
            this.tex = tex;
            this.destRect = destRect;
            this.name = name;
            this.sourceRect = sourceRect;
            this.selected = selected;
            this.selectionSound = selectionSound;
            this.role = role;
            this.randomized = randomized;
        }

        public void DrawChamps(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex, destRect, sourceRect, Color.White);
        }
    }
}
