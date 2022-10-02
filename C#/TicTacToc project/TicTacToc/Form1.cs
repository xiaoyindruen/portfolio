using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToc
{
    public partial class TicTacToc : Form
    {
        bool play = true; // true for player 1, false for player 2

        int playRound = 0;
        public TicTacToc()
        {
            InitializeComponent();
        }

        private void LeftClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (play)
                btn.Text = "X";
               
            else
                btn.Text = "O";

            play = !play;

            btn.Enabled = false;
            playRound++;
            gameRule();
        }

        private void gameRule()
        {
            bool winner = false;

            // horizontal
           if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                winner = true;

           else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                winner = true;

           else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                winner = true;

            // vertical
           else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                winner = true;

            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                winner = true;

            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                winner = true;

            //diagnal
        
             else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                winner = true;

             else if ((btn3.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn7.Enabled))
                winner = true;

            


            if (winner == true)
            {
                String player = "";
                if (play) 
                    player = "O"; 
                else
                    player = "X";
                MessageBox.Show($"{player} Won", "Result");
            }

            else if (playRound == 9)
                MessageBox.Show("It is a draw", "Result");
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //reset button values to empty for restart
        private void button1_Click(object sender, EventArgs e) 
        {         
                
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true; 
            btn5.Enabled = true; 
            btn6.Enabled = true; 
            btn7.Enabled = true; 
            btn8.Enabled = true; 
            btn9.Enabled = true;

            playRound = 0;
        }
    }
}
