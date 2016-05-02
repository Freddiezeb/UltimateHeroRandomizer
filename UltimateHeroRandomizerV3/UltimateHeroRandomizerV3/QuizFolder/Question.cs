using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateHeroRandomizerV3
{
    class Question
    {

        public string q, a1, a2, a3, a4;

        public bool answered;

        public int correctAnswer;

        public Question(string q, string a1, string a2, string a3, string a4, ref bool answered, int correctAnswer)
        {

            this.q = q;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.answered = answered;
            this.correctAnswer = correctAnswer;
        }


    }
}
