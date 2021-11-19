using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public string player1 = "X";
        public string player2 = "O";
        public int rradha = 0;

        // Button controller
        public bool buttone1, buttone2, buttone3, buttone4, buttone5, buttone6, buttone7, buttone8, buttone9;
        public Form1()
        {
            InitializeComponent();
        }

        public void enablebutton()
        {
            buttone1 = true;
            buttone2 = true;
            buttone3 = true;
            buttone4 = true;
            buttone5 = true;
            buttone6 = true;
            buttone7 = true;
            buttone8 = true;
            buttone9 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttone1)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button1.Text = player1;
                    button1.ForeColor = Color.Red;

                }
                else
                {
                    button1.Text = player2;
                    button1.ForeColor = Color.White;
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
                buttone1 = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enablebutton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (buttone2)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button2.Text = player1;
                    button2.ForeColor = Color.Red;
                }
                else
                {
                    button2.Text = player2;
                    button2.ForeColor = Color.White;
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
                buttone2 = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttone3)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button3.Text = player1;
                    button3.ForeColor = Color.Red;
                }
                else
                {
                    button3.Text = player2;
                    button3.ForeColor = Color.White;
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
                buttone3 = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if (buttone4)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button4.Text = player1;
                    button4.ForeColor = Color.Red;
                }
                else
                {
                    button4.Text = player2;
                    button4.ForeColor = Color.White;
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
                buttone4 = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           if (buttone5)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button5.Text = player1;
                    button5.ForeColor = Color.Red;
                }
                else
                {
                    button5.Text = player2;
                    button5.ForeColor = Color.White;
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
                buttone5 = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           if (buttone6)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button6.Text = player1;
                    button6.ForeColor = Color.Red;
                }
                else
                {
                    button6.Text = player2;
                    button6.ForeColor = Color.White;
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
                buttone6 = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          if (buttone7)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button7.Text = player1;
                    button7.ForeColor = Color.Red;
                }
                else
                {
                    button7.Text = player2;
                    button7.ForeColor = Color.White;
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
                buttone7 = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           if (buttone8)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button8.Text = player1;
                    button8.ForeColor = Color.Red;
                }
                else
                {
                    button8.Text = player2;
                    button8.ForeColor = Color.White;
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
                buttone8 = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           if (buttone9)
            {
                //Koontrolloje rradhen e lojtareve
                if (rradha % 2 == 0)
                {
                    //Kur mbetja eshte 0 ateher rradhen ka player 1, ne te kunderten rradhen ka player 2.
                    button9.Text = player1;
                    button9.ForeColor = Color.Red;
                }
                else
                {
                    button9.Text = player2;
                    button9.ForeColor = Color.White;
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
                buttone9 = false;
            }
        
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
            enablebutton();
        }
    }

}
