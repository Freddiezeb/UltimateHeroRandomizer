using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class ButtonManager
    {
        Texture2D tex;
        Button[] buttons;

        Rectangle rect;

        public bool randomize;
        public bool createFilter;
        public bool restoreFilter;

        public ButtonManager(Texture2D tex)
        {
            this.tex = tex;
        }

        public void LoadButtons()
        {

            buttons = new Button[3];

            for (int i = 0; i < buttons.Length; i++)
            {
                rect = new Rectangle(200 + i * 300, 810, 150, 60);
                buttons[i] = new Button(tex, rect);
            }

        }

        public void ButtonUpdate(MouseState mouse)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Update();

                if (buttons[0].Clicked)
                {
                    createFilter = true;
                    buttons[0].Clicked = false;
                }
                if (buttons[1].Clicked)
                {
                    randomize = true;
                    buttons[1].Clicked = false;
                }
                if (buttons[2].Clicked)
                {
                    restoreFilter = true;
                    buttons[2].Clicked = false;
                }
            }

            

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                rect = new Rectangle(200 + i * 300, 810 , 150, 60);
                buttons[i].Draw(spriteBatch, rect);
            }

            spriteBatch.DrawString(Game1.font, "Create Filter", new Vector2(230, 830), Color.White);
            spriteBatch.DrawString(Game1.font, "Randomize!", new Vector2(533, 830), Color.White);
            spriteBatch.DrawString(Game1.font, "Restore Champions", new Vector2(807, 830), Color.White);
        }
    }
}
