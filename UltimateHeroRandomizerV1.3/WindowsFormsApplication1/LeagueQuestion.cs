using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LeagueQuestion
    {

        public string questionText;

        public string Answer1, Answer2, Answer3, Answer4;

        public LeagueQuestion(string questionText, string Answer1, string Answer2, string Answer3, string Answer4)
        {
            this.questionText = questionText;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
            this.Answer4 = Answer4;
        }

        public void Question1()
        {
            questionText = "What is historically the most succesfull EU team?";

            Answer1 = "Fnatic";

            Answer2 = "Alliance";

            Answer3 = "Dragonborns";

            Answer4 = "Meet Your Makers";
        }

        public void Question2()
        {
            questionText = "What is does TSM stand for?";

            Answer1 = "Team Magnum Machine";

            Answer2 = "Technique Star Module";

            Answer3 = "Team Solo Mid";

            Answer4 = "Team Reginald";
        }

        public void Question3()
        {
            questionText = "Which player do Thoorin idolize the most?";

            Answer1 = "YoungBuck";

            Answer2 = "Flame";

            Answer3 = "Amazing";

            Answer4 = "Faker";
        }

        public void Question4()
        {
            questionText = "What team did the caster Kobe play for?";

            Answer1 = "CLG";

            Answer2 = "TSM";

            Answer3 = "Team Velocity";

            Answer4 = "Dignitas";
        }

        public void Question5()
        {
            questionText = "Who needs to get on Skype?";

            Answer1 = "Jonas";

            Answer2 = "Reginald";

            Answer3 = "Rhux";

            Answer4 = "Joel";
        }

        public void Question6()
        {
            questionText = "Who is more toxic?";

            Answer1 = "Incarnation";

            Answer2 = "XJ9";

            Answer3 = "Darkwinjax";

            Answer4 = "Adam";
        }
        public void Question7()
        {
            questionText = "What champion is the most frustrating" + Environment.NewLine + "to play against?";

            Answer1 = "Jarvan";

            Answer2 = "Tahm Kench";

            Answer3 = "Sona";

            Answer4 = "Yorick";
        }
        public void Question8()
        {
            questionText = "Which team won World Championship 2015?";

            Answer1 = "SKT T1";

            Answer2 = "Fnatic";

            Answer3 = "Origins";

            Answer4 = "Samsung White";
        }
        public void Question9()
        {
            questionText = "How do you make you base spawn 'Super minions' ?";

            Answer1 = "You ace the enemy team";

            Answer2 = "You destroy your own inhibitor";

            Answer3 = "You destroy your enemy's inhibitor";

            Answer4 = "You kill the third dragon";
        }
        public void Question10()
        {
            questionText = "Which character can you not milk?";

            Answer1 = "Sona";

            Answer2 = "Azir";

            Answer3 = "Poppy";

            Answer4 = "Alistar";
        }
        public void Question11()
        {
            questionText = "Which summoner goes by the alias 'Bjerger King'?";

            Answer1 = "Faker";

            Answer2 = "Xpeke";

            Answer3 = "Bjergsen";

            Answer4 = "Huni";
        }
        public void Question12()
        {
            questionText = "How many people play LoL everyday?";

            Answer1 = "5 millions";

            Answer2 = "8 millions";

            Answer3 = "13 millions";

            Answer4 = "It's more than 27 millions!!";
        }
        public void Question13()
        {
            questionText = "How long is the channeling time for Teleport?";

            Answer1 = "3.5 seconds";

            Answer2 = "2 seconds";

            Answer3 = "2.5 seconds";

            Answer4 = "3 seconds";
        }
        public void Question14()
        {
            
        }
    }
}
