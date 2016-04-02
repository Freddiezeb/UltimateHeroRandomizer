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

        public void LoadQuestion(ref string qText, ref string answer1, ref string answer2, ref string answer3, ref string answer4, ref int correctAnswerNr)
        {

            for (int i = 0; i < questions.Length; i++)
            {

                i = rnd.Next(0, totalQuestions);
          
                qText = questions[i].q;
                answer1 = questions[i].a1;
                answer2 = questions[i].a2;
                answer3 = questions[i].a3;
                answer4 = questions[i].a4;
                correctAnswerNr = questions[i].correctAnswer;


                if (!questions[i].answered)
                {
                    questions[i].answered = true;
                    break;
                }
            }
        }

        public void QuestionInfo()
        {

            questions[0] = new LeagueQuestion("What champion has poision darts?", "Teemo", "Olaf", "Zed", "Jayce", ref answered, 1);
            questions[1] = new LeagueQuestion("What champion was relased first?", "Yorick", "Gnar", "Jhin", "Renekton", ref answered, 4);
            questions[2] = new LeagueQuestion("What champion is also known as \n\"the Card Master?\"", "Yasuo", "Jayce", "Talon", "Twisted Fate", ref answered, 4);
            questions[3] = new LeagueQuestion("What character has an ability to heal?", "Zilean", "Soraka", "Riven", "Ryze", ref answered, 2);
            questions[4] = new LeagueQuestion("What champion has a Spirit Guard skin?", "Udyr", "Janna", "Rengar", "Vi", ref answered, 1);


            questions[5] = new LeagueQuestion("What company released League of Legends?", "Ubisoft", "Riot Games", "EA DICE", "Valve", ref answered, 2);
            questions[6] = new LeagueQuestion("What champion is also known as \n\"the Spider Queen?\"", "Xin Zhao", "Zyra", "Elise", "Urgot", ref answered, 3);
            questions[7] = new LeagueQuestion("What champ have an urf skin?", "Talon", "Wukong", "Maokai", "Tahm Kench", ref answered, 4);
            questions[8] = new LeagueQuestion("What rank is the highest?", "Platinum", "Diamond", "Challenger", "Master", ref answered, 3);
            questions[9] = new LeagueQuestion("What character has no friends?", "Tristana", "Amumu", "Teemo", "Jarvan IV", ref answered, 2);

            questions[10] = new LeagueQuestion("What champion have a bird called Valor?", "Quinn", "Ashe","Urgot","Swain", ref answered, 1);
            questions[11] = new LeagueQuestion("What champion is insvisible?", "Olaf", "Evelynn","Yorick", "Zac", ref answered, 2);
            questions[12] = new LeagueQuestion("What champion is also known as \n\"the Tidal Trickster?\"", "Shaco", "Fizz", "Riven", "Ezreal", ref answered, 2);
            questions[13] = new LeagueQuestion("What champion is also known as \n\"the Sinister Blade?\"", "Katarina", "Fiora", "Garen", "Aatrox", ref answered, 1);
            questions[14] = new LeagueQuestion("What champion is also known as \n\"the Iron Revenant?\"", "Trundle", "Mordekaiser", "Taric", "Rumble", ref answered, 2);


        }
    }
}
