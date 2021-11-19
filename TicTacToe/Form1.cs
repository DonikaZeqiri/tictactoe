using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public string player1 = "X";
        public string player2 = "O";
        public int rradha = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button1.Text = player1;
                
            }
            else
            {
                button1.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);

            }
            rradha++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button2.Text = player1;
            }
            else
            {
                button2.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);

            }
            rradha++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button3.Text = player1;
            }
            else
            {
                button3.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);

            }
            rradha++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button4.Text = player1;
            }
            else
            {
                button4.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);
                
            }
            rradha++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button5.Text = player1;
            }
            else
            {
                button5.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);
                
            }
            rradha++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button6.Text = player1;
            }
            else
            {
                button6.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);
                
            }
            rradha++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button7.Text = player1;
            }
            else
            {
                button7.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);
               
            }
            rradha++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button8.Text = player1;
            }
            else
            {
                button8.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);
                
            }
            rradha++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Koontrolloje rradhen e lojtareve
            if (rradha % 2 == 0)
            {
                //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                button9.Text = player1;
            }
            else
            {
                button9.Text = player2;
            }
            Boolean fit = Fituesi();
            if (fit)
            {
                String lojtari = player2;
                if (rradha % 2 == 0)
                {
                    lojtari = player1;
                }
                MessageBox.Show("Urime Fituesi eshte lojtari " + lojtari);
            }
            rradha++;
        
        }

        public Boolean Fituesi() {
            //Per rresht
            if (button1.Text.Equals(button2.Text) && button1.Text.Equals(button3.Text))
            {
                return true;
            }
            //Per rresht
            if (button4.Text.Equals(button5.Text) && button4.Text.Equals(button6.Text))
                {
                return true;
            }
            //Per rresht
            if (button7.Text.Equals(button8.Text) && button7.Text.Equals(button9.Text))
                {
                return true;
            }
            //Per kolona
            if (button1.Text.Equals(button4.Text) && button1.Text.Equals(button7.Text))
                {
                return true;
            }
            //Per kolona
            if (button2.Text.Equals(button5.Text) && button2.Text.Equals(button8.Text))
                {
                return true;
            }
            //Per kolona
            if (button3.Text.Equals(button6.Text) && button3.Text.Equals(button9.Text))
            {
                return true;
            }
            //Per diagonale
            if (button1.Text.Equals(button5.Text) && button1.Text.Equals(button9.Text))
            {
                return true;
            }
            //Per diagonale
            if (button3.Text.Equals(button5.Text) && button3.Text.Equals(button7.Text))
            {
                return true;
            }
            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "     ";
            button2.Text = "        ";
            button3.Text = "          ";
            button4.Text = "            ";
            button5.Text = "              ";
            button6.Text = "             ";
            button7.Text = "               ";
            button8.Text = "                 ";
            button9.Text = "                   ";
        }
    }

}
