using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SlidePuzzle : Form
    {

        float time = 0;

        public SlidePuzzle()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Aqua;
            pictureBox2.BackColor = Color.Aqua;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.Aqua;
            pictureBox5.BackColor = Color.Aqua;
            pictureBox6.BackColor = Color.Aqua;
            pictureBox7.BackColor = Color.Aqua;
            pictureBox8.BackColor = Color.Aqua;
            pictureBox9.BackColor = Color.Aqua;

            pictureBox1.Image = Properties.Resources.puzzle_test_01;
            pictureBox2.Image = Properties.Resources.puzzle_test_05;
            pictureBox3.Image = Properties.Resources.puzzle_test_03;
            pictureBox4.Image = Properties.Resources.puzzle_test_08;
            pictureBox5.Image = Properties.Resources.puzzle_test_04;
            pictureBox6.Image = Properties.Resources.puzzle_test_07;
            pictureBox7.Image = Properties.Resources.puzzle_test_02;
            pictureBox8.Image = Properties.Resources.puzzle_test_06;
            pictureBox9.Image = Properties.Resources.puzzle_test_09;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox1.Image = Properties.Resources.puzzle_test_03;
                pictureBox1.BackColor = Color.White;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox1.Image = Properties.Resources.puzzle_test_03;
                pictureBox1.BackColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox1.BackColor = Color.Aqua;
                pictureBox2.Image = Properties.Resources.puzzle_test_03;
                pictureBox2.BackColor = Color.White;
            }

            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox3.BackColor = Color.Aqua;
                pictureBox2.Image = Properties.Resources.puzzle_test_03;
                pictureBox2.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox2.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox2.Image = Properties.Resources.puzzle_test_03;
                pictureBox2.BackColor = Color.White;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox3.Image = Properties.Resources.puzzle_test_03;
                pictureBox3.BackColor = Color.White;
            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox3.Image;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox3.Image = Properties.Resources.puzzle_test_03;
                pictureBox3.BackColor = Color.White;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox4.Image;
                pictureBox1.BackColor = Color.Aqua;
                pictureBox4.Image = Properties.Resources.puzzle_test_03;
                pictureBox4.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox4.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox4.Image = Properties.Resources.puzzle_test_03;
                pictureBox4.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox4.Image;
                pictureBox7.BackColor = Color.Aqua;
                pictureBox4.Image = Properties.Resources.puzzle_test_03;
                pictureBox4.BackColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox5.Image;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.puzzle_test_03;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox5.Image;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.puzzle_test_03;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.puzzle_test_03;
                pictureBox5.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox5.Image;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox5.Image = Properties.Resources.puzzle_test_03;
                pictureBox5.BackColor = Color.White;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox6.Image;
                pictureBox3.BackColor = Color.Aqua;
                pictureBox6.Image = Properties.Resources.puzzle_test_03;
                pictureBox6.BackColor = Color.White;
            }

            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox6.Image = Properties.Resources.puzzle_test_03;
                pictureBox6.BackColor = Color.White;
            }

            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox6.Image;
                pictureBox9.BackColor = Color.Aqua;
                pictureBox6.Image = Properties.Resources.puzzle_test_03;
                pictureBox6.BackColor = Color.White;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox7.Image;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox7.Image = Properties.Resources.puzzle_test_03;
                pictureBox7.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox7.Image = Properties.Resources.puzzle_test_03;
                pictureBox7.BackColor = Color.White;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox8.Image;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox8.Image = Properties.Resources.puzzle_test_03;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox7.BackColor = Color.Aqua;
                pictureBox8.Image = Properties.Resources.puzzle_test_03;
                pictureBox8.BackColor = Color.White;
            }

            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox8.Image;
                pictureBox9.BackColor = Color.Aqua;
                pictureBox8.Image = Properties.Resources.puzzle_test_03;
                pictureBox8.BackColor = Color.White;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox9.Image;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox9.Image = Properties.Resources.puzzle_test_03;
                pictureBox9.BackColor = Color.White;
            }

            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox9.Image;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox9.Image = Properties.Resources.puzzle_test_03;
                pictureBox9.BackColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
