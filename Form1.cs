using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator__v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ans = 0, num1, num2;
        int addClick = 0, divClick = 0,multiClick = 0,minClick = 0;

        //FUNCTION FOR A,D,M,M
        private void checkandset() {
            if (addClick == 1)
            {
                num2 = Convert.ToDouble(ansField.Text);
                num1 += num2;
                addClick = 0;
            }
            else if (minClick == 1)
            {
                num2 = Convert.ToDouble(ansField.Text);
                num1 -= num2;
                minClick = 0;
            }
            else if (multiClick == 1)
            {
                num2 = Convert.ToDouble(ansField.Text);
                num1 *= num2;
                multiClick = 0;
            }
            else if (divClick == 1)
            {
                num2 = Convert.ToDouble(ansField.Text);
                num1 /= num2;
                divClick = 0;
            
            }
            else {
                num1 = Convert.ToDouble(ansField.Text);
            }
        }


        //ZERO BUTTON
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8) {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "0";
                }
                else {
                    ansField.Text = ansField.Text + "0";
                
                }
            
            }
        }
        //ONE BUTTON
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals("")) {
                    ansField.Text = "1";
                }
                else
                {
                    ansField.Text = ansField.Text + "1";
                }

            }
        }
        //TWO BUTTON
        private void twoButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "2";
                }
                else
                {
                    ansField.Text = ansField.Text + "2";
                }

            }
        }
        //THREE BUTTON
        private void threeButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "3";
                }
                else
                {
                    ansField.Text = ansField.Text + "3";
                }

            }
        }
        //FOUR BUTTON
        private void fourButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "4";
                }
                else
                {
                    ansField.Text = ansField.Text + "4";
                }

            }
        }
        //FIVE BUTTON
        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "5";
                }
                else
                {
                    ansField.Text = ansField.Text + "5";
                }

            }
        }
        //SIX BUTTON
        private void sixButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "6";
                }
                else
                {
                    ansField.Text = ansField.Text + "6";
                }

            }
        }
        //SEVEN BUTTON
        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "7";
                }
                else
                {
                    ansField.Text = ansField.Text + "7";
                }

            }
        }
        //EIGHT BUTTON
        private void eightButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "8";
                }
                else
                {
                    ansField.Text = ansField.Text + "8";
                }

            }
        }
        //NINE BUTTON
        private void nineButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Length <= 8)
            {
                if (ansField.Text.Equals(""))
                {
                    ansField.Text = "9";
                }
                else
                {
                    ansField.Text = ansField.Text + "9";
                }

            }
        }
        //DECIMAL BUTTON
        private void decButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                if (ansField.Text.Contains(","))
                {

                }
                else
                {
                    ansField.Text = ansField.Text + ",";
                }
            }
        }
        // C# BUTTON
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ansField.Text = "";
            ans = 0; num1 = 0; num2 = 0;
            addClick = 0; divClick = 0; multiClick = 0; minClick = 0;
            Field.Text = "";
        }
        // PLUS AND MINUS BUTTON
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                if (ansField.Text.Contains("."))
                {
                    double x = Double.Parse(ansField.Text);
                    x *= -1;
                    ansField.Text = Convert.ToString(x);
                }
                else
                {
                    double x = Double.Parse(ansField.Text);
                    x *= -1;
                    ansField.Text = Convert.ToString(x);
                }
            }
        }
        // ADD BUTTON
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                checkandset();
                Field.Text = Field.Text + ansField.Text + addButton.Text;
                ansField.Text = "";

                addClick = 1;
            }
        }
        // MIN BUTTON
        private void MinButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                checkandset();
                Field.Text = Field.Text + ansField.Text + MinButton.Text;
                ansField.Text = "";

                minClick = 1;
            }
        }

        // DIV BUTTON
        private void DivButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                if (ansField.Equals("0"))
                {
                    ansField.Text = "You can't divide by 0";
                }
                else
                {

                    checkandset();
                    Field.Text = Field.Text + ansField.Text + DivButton.Text;
                    ansField.Text = "";

                    divClick = 1;
                }
            }
        }
        // MULTI B
        private void MultiButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                checkandset();
                Field.Text = Field.Text + ansField.Text + MultiButton.Text;
                ansField.Text = "";

                multiClick = 1;
            }
        }
        //EQUALS B
        private void equalButton_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                num2 = Convert.ToDouble(ansField.Text);
                if (addClick == 1)
                {
                    ans = num1 + num2;
                }
                else if (minClick == 1)
                {
                    ans = num1 - num2;
                }
                else if (multiClick == 1)
                {
                    ans = num1 * num2;
                }
                else if (divClick == 1)
                {
                    ans = num1 / num2;
                }

                Field.Text = "";
                ansField.Text = Convert.ToString(ans);
            }
        }

        //MENU STRIP 
        private void kvadratsakneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { } else {
                double x = Convert.ToDouble(ansField.Text);
                x = Math.Sqrt(x);
                ansField.Text = Convert.ToString(x);
            }
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                double x = Convert.ToDouble(ansField.Text);
                x = Math.Cos(x);
                ansField.Text = Convert.ToString(x);
            }
        }

        private void sisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ansField.Text.Equals("")) { }
            else
            {
                double x = Convert.ToDouble(ansField.Text);
                x = Math.Sin(x);
                ansField.Text = Convert.ToString(x);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansField.Font = new Font("Comic Sans MS", 16, FontStyle.Bold);
            Field.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);
            oneButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            twoButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            threeButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            fourButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            fiveButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            sixButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            sevenButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            eightButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            nineButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            zeroButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            ClearButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            MultiButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            addButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            DivButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            MultiButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            equalButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            decButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            PlusMinusButton.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            papildusToolStripMenuItem.Font = new Font("Comic Sans MS",9 , FontStyle.Bold);
            iestatijumiToolStripMenuItem.Font = new Font("Comic Sans MS", 9, FontStyle.Bold);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ansField.Font = new Font("Arial", 16, FontStyle.Bold);
            Field.Font = new Font("Arial", 10, FontStyle.Bold);
            oneButton.Font = new Font("Arial", 8, FontStyle.Bold);
            twoButton.Font = new Font("Arial", 8, FontStyle.Bold);
            threeButton.Font = new Font("Arial", 8, FontStyle.Bold);
            fourButton.Font = new Font("Arial", 8, FontStyle.Bold);
            fiveButton.Font = new Font("Arial", 8, FontStyle.Bold);
            sixButton.Font = new Font("Arial", 8, FontStyle.Bold);
            sevenButton.Font = new Font("Arial", 8, FontStyle.Bold);
            eightButton.Font = new Font("Arial", 8, FontStyle.Bold);
            nineButton.Font = new Font("Arial", 8, FontStyle.Bold);
            zeroButton.Font = new Font("Arial", 8, FontStyle.Bold);
            ClearButton.Font = new Font("Arial", 8, FontStyle.Bold);
            MultiButton.Font = new Font("Arial", 8, FontStyle.Bold);
            addButton.Font = new Font("Arial", 8, FontStyle.Bold);
            DivButton.Font = new Font("Arial", 8, FontStyle.Bold);
            MultiButton.Font = new Font("Arial", 8, FontStyle.Bold);
            equalButton.Font = new Font("Arial", 8, FontStyle.Bold);
            decButton.Font = new Font("Arial", 8, FontStyle.Bold);
            PlusMinusButton.Font = new Font("Arial", 8, FontStyle.Bold);
            papildusToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            iestatijumiToolStripMenuItem.Font = new Font("Segoe UI", 9, FontStyle.Regular);
        }

      

       
    }
}
