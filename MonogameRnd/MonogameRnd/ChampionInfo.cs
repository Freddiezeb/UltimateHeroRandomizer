using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MonogameRnd
{
    class ChampionInfo
    {
        string[] champNames;

        public void GetChampionInfo(ref Champion[] champions)
        {
            //Roles:
            //1 = Marksman
            //2 = Mage
            //3 = Assassin
            //4 = Fighter
            //5 = Tank
            //6 = Support

            string[] names = new string[130];

            string[] role = new string[13];

            StreamReader streamReader = new StreamReader("championNames.txt");

            while (!streamReader.EndOfStream)
            {
                for (int i = 0; i < 130; i++)
                {
                    names[i] = streamReader.ReadLine();
                }
            }


            streamReader = new StreamReader("championRoles.txt");

            while (!streamReader.EndOfStream)
            {
                for (int i = 0; i < 13; i++)
                {
                    role[i] = streamReader.ReadLine();
                }
            }

            for (int i = 0; i < 130; i++)
            {
                champions[i].name = names[i];
                
            }

            for (int i = 0; i < 13; i++)
            {
                champions[i].role = role[i];

            }

        }
    }
}
