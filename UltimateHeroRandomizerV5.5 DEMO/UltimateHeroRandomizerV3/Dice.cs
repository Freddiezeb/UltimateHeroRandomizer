using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateHeroRandomizerV3
{
    public partial class Dice : Form
    {
            #region Declaration

        Image[] diceImages;

        Player player1;

        int bossHealth = 100;
        //int currentBossHealth;
        #endregion

        #region Initialize
        public Dice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //KeyMouseReader.Update();

            player1 = new Player("Player");
            //player2 = new Player("Player 2");

            //lbl_p1Name.Text = player1.Name;
            //lbl_p2Name.Text = player2.Name;

            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice0;
            diceImages[1] = Properties.Resources.dice1;
            diceImages[2] = Properties.Resources.dice2;
            diceImages[3] = Properties.Resources.dice3;
            diceImages[4] = Properties.Resources.dice4;
            diceImages[5] = Properties.Resources.dice5;
            diceImages[6] = Properties.Resources.dice6;

            //lbl_bossHP.Text = bossHealth;
        }

        #endregion

        #region Private Methods

        //Spelarens tärningskast
        private void btn_p1RollDice_Click(object sender, EventArgs e) //Ändra namnet sen till btn_p2RollDice_Click
        {
            if (!player1.Played)
            {
                player1.RollDice();

                lbl_p1Dice1.Image = diceImages[player1.Dice[0]];
                lbl_p1Dice2.Image = diceImages[player1.Dice[1]];
                lbl_p1Dice3.Image = diceImages[player1.Dice[2]];
                lbl_p1Dice4.Image = diceImages[player1.Dice[3]];
                lbl_p1Dice5.Image = diceImages[player1.Dice[4]];
                lbl_p1DisplayResults.Text = player1.Result;

                player1.Played = true;

                //Bossen tar damage + om bossens liv = 0 vinner man
                if (player1.Played)
                {
                    //currentBossHealth = bossHealth - dmg;
                    bossHealth -= 50;
                    this.healthBar.Increment(-bossHealth);

                    if (bossHealth == 0)
                    {
                        Winning();
                        btn_p1RollDice.Enabled = false;
                        MessageBox.Show("Grats u faking knoob");
                    }
                }
                player1.ResetPlayer();
            }
        }

        //Kollar om man vunnit
        private void Winning()
        {
            if (bossHealth == 0)
            {
                lbl_winnerResult.Text = "Player Wins";
                player1.Played = true;
            }
        }

        private void Damage(int dmg)
        {
            if (player1.HandRank >= 6)
                dmg = 20;

            if (player1.HandRank <= 5)
                dmg = 10;
        }

        #endregion

        //Health bar
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
