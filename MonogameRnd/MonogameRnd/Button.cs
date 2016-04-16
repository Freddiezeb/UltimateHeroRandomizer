using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class Button
    {
        private Texture2D ButtonTex;
        private Rectangle ButtonRec;
        private Color ButtonColor = new Color(225, 225, 255, 255);
        private Rectangle rect;

        public bool ButtonFade;
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
                if (ButtonColor.A == 255) ButtonFade = false;
                if (ButtonColor.A == 0) ButtonFade = true;
                if (ButtonFade) ButtonColor.A += 3; else ButtonColor.A -= 3;

                if (KeyMouseReader.mouseState.LeftButton == ButtonState.Pressed && KeyMouseReader.oldMouseState.LeftButton == ButtonState.Released)
                {
                    Clicked = true;
                    ButtonColor.A = 255;
                }
            }
            else if (ButtonColor.A < 255)
            {
                ButtonColor.A += 3;
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

