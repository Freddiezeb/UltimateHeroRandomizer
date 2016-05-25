using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateHeroRandomizerV3
{
    class QuestionManager
    {

        Question[] questions;

        bool answered;

        Random rnd;

        int totalQuestions = 40;

        public QuestionManager()
        {
            rnd = new Random();
            questions = new Question[totalQuestions];
            QuestionInfo();

        }

        public void LoadQuestion(ref string qText, ref string answer1, ref string answer2, ref string answer3, ref string answer4, ref int correctAnswerNr, ref Image image)
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
                image = questions[i].image;


                if (!questions[i].answered)
                {
                    questions[i].answered = true;
                    break;
                }
                if (i == 39 && questions[39].answered)
                {
                    i = 0;
                }

            }
        }


        public void QuestionInfo()
        {
            if (Quiz.leagueQuestions)
            {
                questions[0] = new Question("What champion has poison darts?", "Teemo", "Olaf", "Zed", "Jayce", ref answered, 1,null);
                questions[1] = new Question("What champion was relased first?", "Yorick", "Gnar", "Jhin", "Renekton", ref answered, 4,null);
                questions[2] = new Question("What champion is also known as \n\"the Card Master?\"", "Yasuo", "Jayce", "Talon", "Twisted Fate", ref answered, 4,null);
                questions[3] = new Question("What character has an ability to \n\"heal teammates?", "Zilean", "Soraka", "Riven", "Ryze", ref answered, 2,null);
                questions[4] = new Question("What champion has a Spirit Guard skin?", "Udyr", "Janna", "Rengar", "Vi", ref answered, 1,null);

                questions[5] = new Question("What company released League of Legends?", "Ubisoft", "Riot Games", "EA DICE", "Valve", ref answered, 2,null);
                questions[6] = new Question("What champion is also known as \n\"the Spider Queen?\"", "Xin Zhao", "Zyra", "Elise", "Urgot", ref answered, 3,null);
                questions[7] = new Question("What champ have an urf skin?", "Talon", "Wukong", "Maokai", "Tahm Kench", ref answered, 4,null);
                questions[8] = new Question("What rank is the highest?", "Platinum", "Diamond", "Challenger", "Master", ref answered, 3,null);
                questions[9] = new Question("What character has no friends?", "Tristana", "Amumu", "Teemo", "Jarvan IV", ref answered, 2,null);

                questions[10] = new Question("What champion have a bird called Valor?", "Quinn", "Ashe", "Urgot", "Swain", ref answered, 1,null);
                questions[11] = new Question("What champion is invisible?", "Olaf", "Evelynn", "Yorick", "Zac", ref answered, 2,null);
                questions[12] = new Question("What champion is also known as \n\"the Tidal Trickster?\"", "Shaco", "Fizz", "Riven", "Ezreal", ref answered, 2,null);
                questions[13] = new Question("What champion is also known as \n\"the Sinister Blade?\"", "Katarina", "Fiora", "Garen", "Aatrox", ref answered, 1,null);
                questions[14] = new Question("What champion is also known as \n\"the Iron Revenant?\"", "Trundle", "Mordekaiser", "Taric", "Rumble", ref answered, 2,null);

                questions[15] = new Question("What is the maximum cooldown \n\"reduction for a normal game mode?", "30", "40", "45", "50", ref answered, 3,null);
                questions[16] = new Question("Which team won the \n\"World Championsship 2015?", "SKT T1", "Fnatic", "Origen", "Samsung White", ref answered, 1,null);
                questions[17] = new Question("How do you make your base spawn \n\'Super minions'?", "You ace the enemy team", "You destroy your own inhibitor", "You kill the the third dragon", "You destroy your enemies inhibitor", ref answered, 4, null);
                questions[18] = new Question("How long is the channeling time for \n\"Teleport?", "3.5 seconds", "4 seconds", "2.5 seconds", "3 seconds", ref answered, 2, null);
                questions[19] = new Question("What does is the game mode U.R.F short for?", "Ultimate Raid Fort", "Unit Rain Fight", "Ultra Rapid Fire", "Underground Race Fame", ref answered, 3,null);
               
                questions[20] = new Question("Which one of these pro players \n\"is famous for the Kassadin backdoor?", "xPeke", "Ocelote", "Faker", "Shushei", ref answered, 1,null);              
                questions[21] = new Question("What is the name of this Champion?", "Teemo", "Ashe", "Malzahar", "Poppy", ref answered, 1, ImageManager.teemo);
                questions[22] = new Question("What is the name of this Champion?", "Lucian", "Jhin", "Garen", "Zed", ref answered, 2, ImageManager.jhin);
                questions[23] = new Question("What is the name of this Champion?", "Quinn", "Swain", "Lucian", "Kindred", ref answered, 4, ImageManager.kindred);
                questions[24] = new Question("What is the name of this Champion?", "Morgana", "Janna", "Kayle", "Heimerdinger", ref answered, 1, ImageManager.morgana);

                questions[25] = new Question("What is the name of Jinx Ultimate?", "Rocket Of Doom", "Piltover Explosion", "Super Mega Death Rocket!", "BOOM!", ref answered, 3, null);
                questions[26] = new Question("What is the name of this Champion?", "Trundle", "Olaf", "Gangplank", "Wukong", ref answered, 3, ImageManager.gangplank);
                questions[27] = new Question("What is Barons second name?", "Nashor", "The Beast", "Vilemaw", "Sentinel", ref answered, 1, null);
                questions[28] = new Question("What is the name of this Champion?", "Lee Sin", "Heimerdonger", "Urgot", "Heimerdinger", ref answered, 4, ImageManager.heimer);
                questions[29] = new Question("Which team won season one \n\"World Championship?", "Taipei Assassins", "Fnatic", "against All authority", "CLG.EU", ref answered, 2, null);

                questions[30] = new Question("What Champion is not from the Void?", "Vel'Koz", "Malzahar", "Kassadin", "Aatrox", ref answered, 4, null);
                questions[31] = new Question("What is the name of this Champion?", "Teemo", "Ashe", "Malzahar", "Poppy", ref answered, 1, null);
                questions[32] = new Question("What summoner spell is the \n\"most popular", "Smite", "Ignite", "Flash", "Ghost", ref answered, 3, null);
                questions[33] = new Question("What champion was relased first?", "Zyra", "Hecarim", "Elise", "Quinn", ref answered, 2, null);
                questions[34] = new Question("What champion was relased first?", "Zed", "Ekko", "Bard", "Jinx", ref answered, 2, null);

                questions[35] = new Question("What champion is known for the \n\"simple quote 'ok'?\"", "Rek'Sai", "Shyvana", "Rammus", "Nunu", ref answered, 3, null);
                questions[36] = new Question("How many Mark runes is it possible \n\"to use in a singe rune page?", "9", "8", "6", "3", ref answered, 1, null);
                questions[37] = new Question("In which mastery-tree is the mastery\n\"'Thunderlord's Decree?", "Resolve", "Ferocity", "Cunning", "Sorcery", ref answered, 3, null);
                questions[38] = new Question("What is the limited amount of players\n\"in 'The Challenger Tier?", "300", "250", "400", "200", ref answered, 4, null);
                questions[39] = new Question("What player did Faker outplay in the \n\"famous Zed 1v1?", "Dade", "Ryu", "Pawn", "Cool", ref answered, 2, null);

            }

            if (Quiz.dotaQuestions)
            {
                questions[0] = new Question("Which of these heroes are a pusher?", "Phantom Assassin", "Natures Prophet", "Zeus", "Pudge", ref answered, 2, null);
                questions[1] = new Question("How long is Roshan's respawn time?", "8-11 sec", "5-9 min", "8-11 min", "8-10 min", ref answered, 3, null);
                questions[2] = new Question("After which death does Roshan start to drop cheese?", "his 1st death", "his 2nd death", "his 3rd death", "his 4th death", ref answered, 3, null);
                questions[3] = new Question("Which hero has has the spell \n\"Lightning Bolt?\"", "Zeus", "Io", "Storm Spirit", "Arc Warden", ref answered, 1, null);
                questions[4] = new Question("What does the cheese give you?", "100 gold", "Full hp and mana", "250 gold", "3 sec invulnerability", ref answered, 2, null);

                questions[5] = new Question("Who has the highest base armor?", "Techies", "Ogre Magi", "Dark Seer", "Terrorblade", ref answered, 4, null);
                questions[6] = new Question("What's it called when you wipe a team?", "Nothing", "Rampage", "Ownage", "Genocide", ref answered, 1, null);
                questions[7] = new Question("The first kill is called?", "Bloodbath", "Nothing special", "Bloodlust", "First Blood", ref answered, 4, null);
                questions[8] = new Question("A five man kill is called?", "Penta Kill", "Annihilation", "Rampage", "Onslaught", ref answered, 3, null);
                questions[9] = new Question("Which hero has the toss ability?", "Tidehunter", "Tiny", "Tony", "Tinker", ref answered, 2, null);

                questions[10] = new Question("How many heroes are there?", "111", "112", "115", "118", ref answered, 1, null);
                questions[11] = new Question("What is Dota based on?", "Sims", "LoL", "Call of Duty", "Warcraft", ref answered, 4, null);
                questions[12] = new Question("Tiny's attribute is what?", "Strength", "Intelligence", "Agility", "Power", ref answered, 1, null);
                questions[13] = new Question("This team won The International 5", "Evil Geniuses", "CDEC", "Newbee", "Fnatic", ref answered, 1, null);
                questions[14] = new Question("Spells cost what?", "Spellpower", "Energy", "Mana", "Juice", ref answered, 3, null);

                questions[15] = new Question("Who has the highest MMR?", "Miracle", "talleN", "Owlen", "Matumbaman", ref answered, 2, null);
                questions[16] = new Question("What is this hero called?", "Doom", "Undying", "Lifestealer", "Night Stalker", ref answered, 4, ImageManager.nightstalker);
                questions[17] = new Question("There are most ... type heroes", "Intelligence", "Strength", "Agility", "Power", ref answered, 1, null);
                questions[18] = new Question("How long does Observer Wards last?", "4 min", "5 min", "6 min", "7 min", ref answered, 3, null);
                questions[19] = new Question("What role is IO?", "Tank", "Support", "Carry", "Disabler", ref answered, 2, null);

                questions[20] = new Question("When is the first night?", "4 min", "5 min", "7 min", "10 min", ref answered, 1, null);
                questions[21] = new Question("How many neutral camps in each jungle?", "3", "5", "6", "7", ref answered, 2, null);
                questions[22] = new Question("Reaching level 2 requires ... XP", "100", "200", "300", "400", ref answered, 2, null);
                questions[23] = new Question("First Roshan has how much HP?", "2500", "5000", "7500", "10 000", ref answered, 3, null);
                questions[24] = new Question("What is the maximum movement speed?", "322 ms", "522 ms", "525 ms", "550 ms", ref answered, 2, null);

                questions[25] = new Question("How long does Windrunners Shackleshot success stun for at level 3?", "1.5", "3.75", "6", "3", ref answered, 4, null);
                questions[26] = new Question("How much does a Healing Salve heal for?", "300", "400", "500", "600", ref answered, 2, null);
                questions[27] = new Question("Which of these heroes are a pusher?", "Phantom Assassin", "Natures Prophet", "Zeus", "Pudge", ref answered, 2, null);
                questions[28] = new Question("How much damage is Fissure level 3?", "160", "190", "210", "320", ref answered, 3, null);
                questions[29] = new Question("What is the max range of Meat Hook?", "1200", "1300", "1400", "1500", ref answered, 2,null);

                questions[30] = new Question("What is the name of Drow Ranger's ulti?", "Marksmanship", "Marksman", "Precision Aura", "Dismember", ref answered, 1,null);
                questions[31] = new Question("Who is this hero?", "Anti-Christ", "Anti-Mage", "Anti-Terrorist", "Anti-Hero", ref answered, 2, ImageManager.antimage);
                questions[32] = new Question("What item is this?", "Aghanims Staff", "Magic Scepter", "Almighty Staff", "Aghanims Scepter", ref answered, 2, ImageManager.agha);
                questions[33] = new Question("What Hero is this?", "Queen of Qop", "Queen of Hell", "Queen of Pain", "Queen of Pop", ref answered, 3, ImageManager.qop);
                questions[34] = new Question("Who is this man?", "Keeper of the Staff", "Gandalf", "Keeper of the Light", "Sauroman", ref answered, 3, ImageManager.kotl);

                questions[35] = new Question("Who's spell is 'Spin Web'?", "Spiderman", "Spidermother", "Broodmother", "Black Widow", ref answered, 3, ImageManager.broodmother);
                questions[36] = new Question("Who's spell is 'Suicide Squad, Attack'?", "Osama bin Laden", "Terrorist", "Techer", "Techies", ref answered, 4, ImageManager.techies);
                questions[37] = new Question("What TI did sweden win?", "TI1", "TI3", "TI5", "TI8", ref answered, 2, null);
                questions[38] = new Question("What player is this?", "Dendo", "Dendi", "Denda", "Deadi", ref answered, 2, ImageManager.dendi);
                questions[39] = new Question("What player is this?", "Air", "Dare", "Tear", "Fear", ref answered, 4, ImageManager.fear);

            }



        }

        public void ReviveQuestions()
        {
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].answered = false;
            }
        }
    }
}
