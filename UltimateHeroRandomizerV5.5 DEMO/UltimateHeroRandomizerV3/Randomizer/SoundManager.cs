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

        }
    }
}
