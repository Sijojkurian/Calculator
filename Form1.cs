using System;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        private double value1;
        private double value2;
        private string selectedOp;
        public Form1()
        {   //this is the constructor
            value1 = 0;
            value2 = 0;
            selectedOp = "";
            InitializeComponent();
        }

       
        //THIS FOLLOWING  code controls the numbers
        private void button1_Click(object sender, EventArgs e)
        {
            //when pressing 1, textBox1 =1
            textBox1.Text = textBox1.Text+ "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //when pressing 2, textBox1 =2
            textBox1.Text = textBox1.Text+ "2";
        }
        private void buttonFact_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + ".";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }



        //when pressing equals button, the calculator performs
        //calculations bases on the selected operators below
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                value2 = Convert.ToDouble(textBox1.Text);
                int lastCharacterPosition = textBox1.TextLength - 1;
                CAdvancedMath math = new CAdvancedMath();
                //CBaseMath math = new CBaseMath();
                //in logical operation, use double equal sign
                
                if (selectedOp == "+")
                {
                    //plus
                    textBox1.Text = Convert.ToString(math.Sum(value1, value2));
                }
                else if(selectedOp=="-")
                {
                    //minus
                    textBox1.Text = Convert.ToString(math.Substract(value1, value2));
                }
                else if (selectedOp == "x")
                {
                    //TIMEs
                    textBox1.Text = Convert.ToString(math.Multiply(value1, value2));
                }
                else if (selectedOp == "/")
                {
                    //divide by
                    textBox1.Text = Convert.ToString(math.Divide(value1, value2));
                }
                else if (selectedOp == "%")
                {
                    //percentage
                    textBox1.Text = Convert.ToString(math.Percent(value2));
                }
                else if (selectedOp == "2√x")
                {
                    //square root
                    textBox1.Text = Convert.ToString(math.SqRoot(value2));
                }
                else if (selectedOp == "x^2")
                {
                    //square
                    textBox1.Text = Convert.ToString(math.Square(value2));
                }
                else if (selectedOp == "1/x")
                {
                    //fraction
                    textBox1.Text = Convert.ToString(math.Inverse(value2));
                }

                else if (selectedOp == "x!")
                {
                    //factorial
                    textBox1.Text = Convert.ToString(math.Factorial(value2));
                }

            }
            
            
        }

        private void button3Clear_Click(object sender, EventArgs e)
        {
            //clear it out when pressing clear
            textBox1.Text = "";
            value1 = 0;
            value2 = 0;
        }
        private void button12Clear_Click(object sender, EventArgs e)
        {
            //this is the c button
            textBox1.Clear();
            //value1 = 0;
            //value2 = 0;
            

        }

        private void button13Backspace_Click(object sender, EventArgs e)
        {
            //this is the backspace
            selectedOp = "<X";
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

        }


        //THE following fuctions are used depending on the selected operators
        private void assignToValue1()
        {
            //since this is repetitive
            //by creating this fuction, we can use it in my multiple places
            //can make the changes in this fuction and use it in multiple places
            if (textBox1.Text != "")
            {
                value1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

            }

        }

        private void button3Minus_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text != "")
            {
                value1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";    
            }*/
            assignToValue1();
            selectedOp = "-";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //THIS IS THE PLUS button
            //when pressing plus, this will store the value entered in text box
            /*if (textBox1.Text != "")
            {
                value1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "";
                
            }*/
            assignToValue1();
            selectedOp = "+";

        }
        private void button12Times_Click(object sender, EventArgs e)
        {
            //for times
            assignToValue1();
            selectedOp = "x";

        }

        private void button12Divide_Click(object sender, EventArgs e)
        {
            //divide
            assignToValue1();
            selectedOp = "/";

        }

        private void button12Percentage_Click(object sender, EventArgs e)
        {
            //percentange calc
            selectedOp = "%";
        }

        private void button14SquareRoot_Click(object sender, EventArgs e)
        {
            //this gives squre root
            selectedOp = "2√x"; 
        }

        private void button12Square_Click(object sender, EventArgs e)
        {
            //this is the square 
            selectedOp = "x^2"; 
        }

        private void button12Inverse_Click(object sender, EventArgs e)
        {
            //this is the fraction
            selectedOp = "1/x"; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectedOp = "x!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
