using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class Button
    {
        private Texture2D ButtonTex;
        private Rectangle ButtonRec;
        private Color ButtonColor = Color.White;
        private Rectangle rect;

        public bool Clicked;

        public Button(Texture2D tex, Rectangle rect)
        {
            this.ButtonTex = tex;
            this.rect = rect;
        }

        public void Update()
        {
            ButtonRec = new Rectangle((int)rect.X, (int)rect.Y, ButtonTex.Width, ButtonTex.Height);

            if (ButtonRec.Contains(KeyMouseReader.mouseState.X, KeyMouseReader.mouseState.Y))
            {

                ButtonTex = TextureManager.buttonTexture;
                if (KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    Clicked = true;
                }
            }
            else
            {
                ButtonTex = TextureManager.buttonNeutral;
                Clicked = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle rect)
        {
            this.rect = rect;

            spriteBatch.Draw(ButtonTex, rect, ButtonColor);
        }
    }

}

