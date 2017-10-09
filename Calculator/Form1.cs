using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       // static string operatorToDo;
        double operand1 = 0.0;
        double operand2 = 0.0;
        char operation = '\0';
        double resultVariable = 0;
        bool buttoonPress = false;
        
        public Form1()
        {
            InitializeComponent();
            //operand1 = Convert.ToInt32(Result.Text);
            //operand2 = Convert.ToInt32(Result.Text);
            //Result.Text = "0";
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "2";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "2";
            }
            
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "1";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "1";
            }
            
        }

        public void ClearScreen()
        {
            Result.Text = "";
            //operation = '\0';
            //operand1 = 0;
            //operand2 = 0;

        }
        public void clearOperation()
        {
            operand2 = 0;
            operand1 = 0;
            operation = '\0';
        }

        private void ultraButton3_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "3";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "3";
            }
            
        }

        private void ultraButton4_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "4";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "4";
            }
            
        }

        private void ultraButton5_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "5";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "5";
            }
            
        }

        private void ultraButton6_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "6";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "6";
            }
            
        }

        private void ultraButton7_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "7";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "7";
            }
            
        }

        private void ultraButton8_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "8";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "8";
            }
            
        }

        private void ultraButton9_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "9";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "9";
            }
            
        }

        private void ultraButton0_Click(object sender, EventArgs e)
        {
            if (buttoonPress == false)
            {
                ClearScreen();
                Result.Text = "0";
                buttoonPress = true;
            }
            else
            {
                Result.Text = Result.Text + "0";
            }
            
        }

        private void ultraButtonClear_Click(object sender, EventArgs e)
        {
            
            ClearScreen();
            clearOperation();
            Result.Text = "0";
            buttoonPress = false;
        }

        private void ultraButtonPlus_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToDouble(Result.Text);
            
            if (operation == '\0')
            {
                operand1 = operand2;
                resultVariable = operand1;
            }
            else
            {
                if (operation == '+')
                {
                    resultVariable = operand1 + operand2;
                    operand1 = resultVariable;
                }
                if (operation == '-')
                {
                    resultVariable = operand1 - operand2;
                    operand1 = resultVariable;
                }
                if (operation == '*')
                {
                    resultVariable = operand1 * operand2;
                    operand1 = resultVariable;
                }
                if (operation == '/')
                {
                    resultVariable = operand1 / operand2;
                    operand1 = resultVariable;
                }

                
            }
            operation = '+';
            buttoonPress = false;
            Result.Text = resultVariable.ToString();

            //ClearScreen();
            //bool buttonplus = false;
            //operand2 =  Convert.ToDouble(Result.Text);
            //if (operation == ' ')
            //{
            //    //operand2 =  Convert.ToDouble(Result.Text);
               
            //    operand1 = operand2;
            //}
            //else
            //{
            //    resultVariable= operand1 + operand2;
            //    operand1 = resultVariable;
            //}

            //ClearScreen();
            //Result.Text = "0";
           // int operand2 = Convert.ToInt32(Result.Text);
            //int result = operand1 + operand2;
            //Result.Text = resultVariable.ToString();

            
        }

        
        

        
     
    }
}
