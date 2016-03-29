using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DotaQuestion
    {
        public string questionText;

        public string Answer1, Answer2, Answer3, Answer4;

        public DotaQuestion(string questionText, string Answer1, string Answer2, string Answer3, string Answer4)
        {
            this.questionText = questionText;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
            this.Answer4 = Answer4;
        }

        public void Question1()
        {
            questionText = "Which kind of damage is Witchdoctors ultimate?";

            Answer1 = "Physical damage";

            Answer2 = "Magic damage";

            Answer3 = "True damage";

            Answer4 = "Mixed damage";
        }
        public void Question2()
        {
            questionText = "How much mana does Shadow Fiends Shadowraze cost at level 3?";

            Answer1 = "500";

            Answer2 = "100";

            Answer3 = "90";

            Answer4 = "120";
        }
        public void Question3()
        {
            questionText = "What MOBA-game is the best?";

            Answer1 = "League Of Legends";

            Answer2 = "Dota 2";

            Answer3 = "Heroes of Newerth";

            Answer4 = "Cookie Clicker";
        }
        public void Question4()
        {
            questionText = "Templar Assassins first ability is called Refractions how many number if instances does it have at level 3?";

            Answer1 = "5";

            Answer2 = "2";

            Answer3 = "4";

            Answer4 = "6";
        }
        public void Question5()
        {
            questionText = "What Dota 2 Team won The International 2013?";

            Answer1 = "Natus Vincere";

            Answer2 = "Evil Geniuses";

            Answer3 = "Newbee";

            Answer4 = "Alliance";
        }
        public void Question6()
        {
            questionText = "How much damage does Earth Spitits Magnetize per second at level 3?";

            Answer1 = "200";

            Answer2 = "400";

            Answer3 = "600";

            Answer4 = "100";
        }
        public void Question7()
        {
            questionText = "What Hero got a passive that makes him permanently invisible?";

            Answer1 = "Bounty Hunter";

            Answer2 = "Riki";

            Answer3 = "Natures Prophet";

            Answer4 = "Treant Protector";
        }
        public void Question8()
        {
            questionText = "Clockwerk's ability Power Cogs summon Cogs, but how many?";

            Answer1 = "8";

            Answer2 = "9";

            Answer3 = "6";

            Answer4 = "10";
        }
        public void Question9()
        {
            questionText = "What is the known name of the creater of DotA?";

            Answer1 = "Lenny";

            Answer2 = "Gaben Newell";

            Answer3 = "Ice Frog";

            Answer4 = "Bear Horn";
        }
        public void Question10()
        {
            questionText = "What is Tinkers Ultimate called?";

            Answer1 = "Reload";

            Answer2 = "Reset";

            Answer3 = "Kill Cooldown";

            Answer4 = "Rearm";
        }
        public void Question11()
        {
            questionText = "How much gold does a Animal Courier cost?";

            Answer1 = "150";

            Answer2 = "200";

            Answer3 = "100";

            Answer4 = "120";
        }
        public void Question12()
        {
            questionText = "How much is the full price of Guardian Greves?";

            Answer1 = "5150";

            Answer2 = "4900";

            Answer3 = "4850";

            Answer4 = "5250";
        }
        public void Question13()
        {
            questionText = "How many clones does meepo have at level 25?";

            Answer1 = "3";

            Answer2 = "2";

            Answer3 = "1";

            Answer4 = "5";
        }
    }
}
