using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class SoundManager
    {
        //En klass som håller i alla sounds
        public SoundManager()
        {

        }

        public void LoadSounds(ref Champion[] champions, ContentManager Content)
        {
            ChampionInfo champInfo = new ChampionInfo();
            champInfo.GetChampionInfo(ref champions);

            if (Submenu.League)
            {
                for (int i = 0; i < champions.Length; i++)
                {
                    champions[i].selectionSound = Content.Load<SoundEffect>("SelectionSounds/" + champions[i].name);
                }
            }

            if (Submenu.Dota)
            {
                for (int i = 0; i < champions.Length; i++)
                {
                    if (i == 6 || i == 13 || i == 22 || i == 30 || i == 31 ||i ==32 || i ==36 || i == 38 || i == 62 || i == 71 || i == 91 || i == 92 || i ==93)
                    {
                    champions[i].selectionSound = null;
                    }
                    else
                    {
                        champions[i].selectionSound = Content.Load<SoundEffect>("DotaSounds/" + champions[i].name);
                    }

                }
            }

        }
    }
}
