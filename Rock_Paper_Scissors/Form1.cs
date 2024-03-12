using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{

    public partial class Form1 : Form
    {
        int myScore = 0;
        int oppScore = 0;
        bool played = false;
       
            


        public Form1()
        {
            InitializeComponent();
            this.KeyDown += form_KeyDown;
            pa_label.Visible = false;
            oppPick_label.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int move_picker()
        {
            Random r = new Random();
            int num = r.Next(1, 3);
            return num;
        }
        private string oppChose()
        {
            string chose = "";
            int num = move_picker();
            if (num == 1)
            {
                oppPictureBox.Image = Properties.Resources.rock;
                chose = "rock";
            }
            if (num == 2)
            {
                oppPictureBox.Image = Properties.Resources.paper;
                chose = "paper";
            }
            if (num == 3)
            {
                oppPictureBox.Image = Properties.Resources.scissors;
                chose = "scissor";
            }
            return chose;
        } 



        private void my_pictureBox_Click(object sender, EventArgs e)
        {
           
            PictureBox pb = (PictureBox)sender;
            if (played == true)
            {
                pb.Enabled = false;
            }
            myPick_label.Text = "You made a Pick";
            oppChose();
            string ichose = "";
            if (pb == rock_pictureBox)
            {
                paper_pictureBox3.Visible = false;
                scissor_pictureBox.Visible = false;
                ichose = "Rock";
            }
            if (pb == paper_pictureBox3)
            {
                rock_pictureBox.Visible = false;
                scissor_pictureBox.Visible = false;
                ichose = "Paper";
            }
            if (pb == scissor_pictureBox)
            {
                paper_pictureBox3.Visible = false;
                rock_pictureBox.Visible = false;
                ichose = "Scissor";
            }
            played = true;
            choseWinner(ichose);
            oppPick_label.Visible = false;
            

        }
        private void choseWinner(string ichose)
        {
          string  oppChosed = oppChose();
           if ((oppChosed == "rock" && ichose == "Rock") || (oppChosed == "paper" && ichose == "Paper") || (oppChosed == "scissor" && ichose == "Scissors" ))

            {
                result_label.Text = " Match Tied";
            }
           if ((oppChosed == "rock" && ichose == "Paper") || (oppChosed == "paper" && ichose == "Scissor") || (oppChosed == "scissor" && ichose == "Rock") )
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Rehman\source\repos\Rock_Paper_Scissors\Rock_Paper_Scissors\tu-mera-putr-choti-kr.wav");
                player.Play();
                result_label.Text = "You Won";
                myScore++;

            }
            if ((oppChosed == "rock" && ichose == "Scissor") || (oppChosed == "paper" && ichose == "Rock") || (oppChosed == "scissor" && ichose == "Paper"))
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Rehman\source\repos\Rock_Paper_Scissors\Rock_Paper_Scissors\moye_moye.wav");
                player.Play();
                result_label.Text = "You Lost";
                oppScore++;
            }
            updateScore();
            
            

        }
        private void updateScore()
        {
            myScore_label.Text = "Your Score: " + myScore.ToString();
            oppScore_label.Text = "Opponent's Score: " + oppScore.ToString();
            pa_label.Text = "Press Space-Bar to Play Again ";
            pa_label.Visible = true;
            result_label.Visible = true;


        }
        private void form_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                played = false;
                rock_pictureBox.Visible = true;
                rock_pictureBox.Enabled = true;
                paper_pictureBox3.Visible = true;
                paper_pictureBox3.Enabled = true;
                scissor_pictureBox.Visible = true;
                scissor_pictureBox.Enabled = true;
                pa_label.Visible = false;
                oppPick_label.Visible = true;
                result_label.Visible = false;
            }
            
        }
    }
    
}
