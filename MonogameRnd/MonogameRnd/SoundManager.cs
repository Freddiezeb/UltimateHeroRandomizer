using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class SoundManager
    {
        //Champion[] champions;

        public SoundManager()
        {

        }

        public void LoadSounds(ref Champion[] champions, ContentManager Content)
        {
            champions[0].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Aatrox");
            champions[1].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Ahri");
            champions[2].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Akali");
            champions[3].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Alistar");
            champions[4].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Amumu");
            champions[5].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Anivia");
            champions[6].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Annie");
            champions[7].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Ashe");
            champions[8].selectionSound = Content.Load<SoundEffect>("SelectionSounds/AurelionSol");
            champions[9].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Azir");
            champions[10].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Bard");
            champions[11].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Blitzcrank");
            champions[12].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Brand");
            champions[13].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Braum");
            champions[14].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Caitlyn");
            champions[15].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Cassiopeia");
            champions[16].selectionSound = Content.Load<SoundEffect>("SelectionSounds/ChoGath");
            champions[17].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Corki");
            champions[18].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Darius");
            champions[19].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Diana");
            champions[20].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Draven");
            champions[21].selectionSound = Content.Load<SoundEffect>("SelectionSounds/DrMundo");
            champions[22].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Ekko");
            champions[23].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Elise");
            //champions[24].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[25].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[26].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[27].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[28].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[29].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[30].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[31].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[32].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[33].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[34].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[35].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[36].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[37].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[38].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[39].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[40].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[41].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[42].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[43].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[44].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[45].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[46].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[47].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[48].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[49].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[50].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[51].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[52].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[53].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[54].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[55].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[56].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[57].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[58].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[59].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[60].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[61].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[62].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[63].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[64].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[65].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[66].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[67].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[68].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[69].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[70].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[71].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[72].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[73].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[74].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[75].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[76].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[77].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[78].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[79].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[80].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[81].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[82].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[83].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[84].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[85].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[86].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[87].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[88].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[89].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[90].selectionSound = Content.Load<SoundEffect>("Aatrox");
            //champions[91].selectionSound = Content.Load<SoundEffect>("Aatrox");
        }
    }
}
