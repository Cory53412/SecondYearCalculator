using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.IO;


namespace Corys_Calculator
{
    public partial class MainPage : ContentPage
    {
        string input = ""; //stores the number that the user is currently entering, including - and .
        string firstNumber, secondNumber = ""; //Stored as strings so decimals can be added
        char operation = ' '; //holds operator in use, or space for no operator


        public MainPage()
        {
            InitializeComponent();

           


        }

        //NUMBER BUTTONS
        private void Btn0_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = ""; //clear the text box
            input += "0"; //add this number to the input string
            textDisplay.Text += input; //
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "1";
            textDisplay.Text += input;
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "2";
            textDisplay.Text += input;
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "3";
            textDisplay.Text += input;
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "4";
            textDisplay.Text += input;
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "5";
            textDisplay.Text += input;
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "6";
            textDisplay.Text += input;
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "7";
            textDisplay.Text += input;
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "8";
            textDisplay.Text += input;
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            input += "9";
            textDisplay.Text += input;
        }

        //OPERATORS
        private void BtnPlus_Clicked(object sender, EventArgs e)
        {
            firstNumber = input; //Stores number from the textbox in a string
            operation = '+';
            input = ""; //reset input variable
        }

        private void BtnMinus_Clicked(object sender, EventArgs e)
        {
            //if no number in input, add - to it, for negative number
            if (input == "")
            {
                input += "-";
                textDisplay.Text += input;
            }
            //else use minus as operator
            else
            {
                firstNumber = input; //Stores number from the textbox in a string
                operation = '-';
                input = "";
            }
        }

        private void BtnMultiply_Clicked(object sender, EventArgs e)
        {
            firstNumber = input; //Stores number from the textbox in a string
            operation = '*';
            input = ""; //reset input variable
        }

        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            firstNumber = input; //Stores number from the textbox in a string
            operation = '/';
            input = ""; //reset input variable
        }

        private void BtnEquals_Clicked(object sender, EventArgs e)
        {
            if (operation == ' ') return; //if user presses equal without pressing an operator, do nothing

            secondNumber = input; //stores whatever is currently in the textbox as second number 

            double number1, number2 = 0.0; //doubles to hold the parsed numbers we are currently storing as strings
            double result = 0.0; //double to store result

            //parse numbers from the strings, put into number1 and number2
            double.TryParse(firstNumber, out number1);
            double.TryParse(secondNumber, out number2);

            //plus
            if (operation == '+')
            {
                result = (number1 + number2);
                //textDisplay.Text = result.ToString();
            }
            //minus
            else if (operation == '-')
            {
                result = (number1 - number2);
                //textDisplay.Text = result.ToString();
            }
            //multiply
            else if (operation == '*')
            {
                result = (number1 * number2);
                //textDisplay.Text = result.ToString();
            }
            //divide
            else if (operation == '/')
            {
                //Can't divide by 0
                if (number2 == 0)
                {
                    //display a warning to not divide by 0
                    DisplayAlert("Alert", "Cannot divide by 0", "OK");
                }
                else
                {
                    result = (number1 / number2);
                }
                //textDisplay.Text = (result).ToString();
            }


            //display the result
            textDisplay.Text = result.ToString();

            //keep result input, so you can continue calculating with it.
            input = result.ToString();

            //Clear variables
            firstNumber = "";
            secondNumber = "";
            operation = ' ';
        }


        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            //reset all variables to default values
            input = "";
            firstNumber = "";
            secondNumber = "";
            operation = ' ';
            textDisplay.Text = "";
        }


        private void BtnDecimal_Clicked(object sender, EventArgs e)
        {
            textDisplay.Text = "";
            //if there is no "." already in the textbox
            if (!input.Contains("."))
            {
                input = input += ".";
                textDisplay.Text += input;
            }
            //else does nothing, so you can't put in more than one decimal
        }
    }
}
