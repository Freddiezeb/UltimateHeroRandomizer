using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class QuestionManager
    {

        LeagueQuestion[] questions;

        bool answered;

        Random rnd;

        int totalQuestions = 15;

        public QuestionManager()
        {
            rnd = new Random();
            questions = new LeagueQuestion[totalQuestions];

            QuestionInfo();

        }

        public void SECOND(ref string a, ref string b, ref string c, ref int correctAnswer)
        {

            for (int i = 0; i < questions.Length; i++)
            {

                i = rnd.Next(0, totalQuestions);



                a = questions[i].q1;
                b = questions[i].a1;
                c = questions[i].a2;
                correctAnswer = questions[i].correctAnswer;


                if (!questions[i].answered)
                {
                    questions[i].answered = true;
                    break;
                }


            }
        }

        public void QuestionInfo()
        {

            questions[0] = new LeagueQuestion("What champion has poision darts?", "Teemo", "Olaf", ref answered, 2);
            questions[1] = new LeagueQuestion("Which champion was relased first?", "Yorick", "Renekton", ref answered, 2);
            questions[2] = new LeagueQuestion("What is the name of the blind monk?", "Lee Sin", "Ashe", ref answered, 1);
            questions[3] = new LeagueQuestion("What character has an ability to heal?", "Zilean", "Soraka", ref answered, 2);
            questions[4] = new LeagueQuestion("What champion has a Spirit Guard skin?", "Udyr", "Janna", ref answered, 1);


            questions[5] = new LeagueQuestion("What company name of the owners of LoL", "Riot Games", "Dice", ref answered, 1);
            questions[6] = new LeagueQuestion("League of?", "Draaaven", "Poppy", ref answered, 1);
            questions[7] = new LeagueQuestion("What champ have an urf skin?", "Maokai", "Tahm Kench", ref answered, 2);
            questions[8] = new LeagueQuestion("What rank is the highest?", "Challenger", "Master", ref answered, 1);
            questions[9] = new LeagueQuestion("What character has no friends?", "Tristana", "Amumu", ref answered, 2);

            questions[10] = new LeagueQuestion("Who have a bird called Valor?", "Quinn", "Ashe", ref answered, 1);
            questions[11] = new LeagueQuestion("What champion is insvisible?", "Olaf", "Evelynn", ref answered, 2);
            questions[12] = new LeagueQuestion("Who is better?", "Youngbuck", "Faker", ref answered, 1);
            questions[13] = new LeagueQuestion("What of these used to be a summoners spell?", "Though Skin", "Fortify", ref answered, 2);
            questions[14] = new LeagueQuestion("Who can summon shadows of himself?", "Zed", "Yasuo", ref answered, 1);


            //questions[15] = new LeagueQuestion("CCFF", "QWE", "SAD", ref answered, 2);
        }
    }
}
