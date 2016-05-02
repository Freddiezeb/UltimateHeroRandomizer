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
            champions[24].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Evelynn");
            champions[25].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Ezreal");
            champions[26].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Fiddlesticks");
            champions[27].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Fiora");
            champions[28].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Fizz");
            champions[29].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Galio");
            champions[30].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Gangplank");
            champions[31].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Garen");
            champions[32].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Gnar");
            champions[33].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Gragas");
            champions[34].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Graves");
            champions[35].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Hecarim");
            champions[36].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Heimerdinger");
            champions[37].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Illaoi");
            champions[38].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Irelia");
            champions[39].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Janna");
            champions[40].selectionSound = Content.Load<SoundEffect>("SelectionSounds/JarvanIV");
            champions[41].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Jax");
            champions[42].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Jayce");
            champions[43].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Jhin");
            champions[44].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Jinx");
            champions[45].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Kalista");
            champions[46].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Karma");
            champions[47].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Karthus");
            champions[48].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Kassadin");
            champions[49].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Katarina");
            champions[50].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Kayle");
            champions[51].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Kennen");
            champions[52].selectionSound = Content.Load<SoundEffect>("SelectionSounds/KhaZix");
            champions[53].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Kindred");
            champions[54].selectionSound = Content.Load<SoundEffect>("SelectionSounds/KogMaw");
            champions[55].selectionSound = Content.Load<SoundEffect>("SelectionSounds/LeBlanc");
            champions[56].selectionSound = Content.Load<SoundEffect>("SelectionSounds/LeeSin");
            champions[57].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Leona");
            champions[58].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Lissandra");
            champions[59].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Lucian");
            champions[60].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Lulu");
            champions[61].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Lux");
            champions[62].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Malphite");
            champions[63].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Malzahar");
            champions[64].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Maokai");
            champions[65].selectionSound = Content.Load<SoundEffect>("SelectionSounds/MasterYi");
            champions[66].selectionSound = Content.Load<SoundEffect>("SelectionSounds/MissFortune");
            champions[67].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Aatrox"); // WRONG
            champions[68].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Mordekaiser");
            champions[69].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Morgana");
            champions[70].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Nami");
            champions[71].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Nasus");
            champions[72].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Nautilus");
            champions[73].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Nidalee");
            champions[74].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Nocturne");
            champions[75].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Nunu");
            champions[76].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Olaf");
            champions[77].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Orianna");
            champions[78].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Pantheon");
            champions[79].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Poppy");
            champions[80].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Quinn");
            champions[81].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Rammus");
            champions[82].selectionSound = Content.Load<SoundEffect>("SelectionSounds/RekSai");
            champions[83].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Renekton");
            champions[84].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Rengar");
            champions[85].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Riven");
            champions[86].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Rumble");
            champions[87].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Ryze");
            champions[88].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Sejuani");
            champions[89].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Shaco");
            champions[90].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Shen");
            champions[91].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Shyvana");
            champions[92].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Singed");
            champions[93].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Sion");
            champions[94].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Sivir");
            champions[95].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Skarner");
            champions[96].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Sona");
            champions[97].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Soraka");
            champions[98].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Swain");
            champions[99].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Syndra");
            champions[100].selectionSound = Content.Load<SoundEffect>("SelectionSounds/TahmKench");
            champions[101].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Talon");
            champions[102].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Taric");
            champions[103].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Teemo");
            champions[104].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Thresh");
            champions[105].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Tristana");
            champions[106].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Trundle");
            champions[107].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Tryndamere");
            champions[108].selectionSound = Content.Load<SoundEffect>("SelectionSounds/TwistedFate");
            champions[109].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Twitch");
            champions[110].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Udyr");
            champions[111].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Urgot");
            champions[112].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Varus");
            champions[113].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Vayne");
            champions[114].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Veigar");
            champions[115].selectionSound = Content.Load<SoundEffect>("SelectionSounds/VelKoz");
            champions[116].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Vi");
            champions[117].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Viktor");
            champions[118].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Vladimir");
            champions[119].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Volibear");
            champions[120].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Warwick");
            champions[121].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Xerath");
            champions[122].selectionSound = Content.Load<SoundEffect>("SelectionSounds/XinZhao");
            champions[123].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Yasuo");
            champions[124].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Yorick");
            champions[125].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Zac");
            champions[126].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Zed");
            champions[127].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Ziggs");
            champions[128].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Zilean");
            champions[129].selectionSound = Content.Load<SoundEffect>("SelectionSounds/Zyra");
        }
    }
}
