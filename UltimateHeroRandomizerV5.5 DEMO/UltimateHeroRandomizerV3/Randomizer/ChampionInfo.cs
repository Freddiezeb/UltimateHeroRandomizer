using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UltimateHeroRandomizerV3
{
    class ChampionInfo
    {
        //Klass som håller information om champions namn och deras roll, laddas in genom text-fil.

        public void GetChampionInfo(ref Champion[] champions)
        {
            //Roles:
            //1 = Marksman
            //2 = Mage
            //3 = Assassin
            //4 = Fighter
            //5 = Tank
            //6 = Support

            if (Submenu.League)
            {
                string[] names = new string[130];

                string[] role = new string[130];
            }

            using (StreamReader reader = new StreamReader("championNames.txt"))
            {
                //Läser igenom textfilen via streamreader, sätter en split mellan dess roll och vilken champion det är
                while (!reader.EndOfStream)
                {
                    while (!reader.EndOfStream)
                    {
                        for (int i = 0; i < 130; i++)
                        {
                            string str = reader.ReadLine();

                            string[] split_string = str.Split(',');

                            string characterName = (split_string[0]);
                            string characterRole = (split_string[1]);

                            champions[i].name = characterName;
                            champions[i].role = characterRole;
                        }
                    }
                }
            }

        }
    }
}

