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
        public Form1()
        {
            InitializeComponent();
            inputBox.Text = "";
        }

        private void zeroBt_Click(object sender, EventArgs e)
        {
            haveZero();
            inputBox.Text += 0;
        }

        private void oneBt_Click(object sender, EventArgs e)
        {
            haveZero();
            inputBox.Text += 1;
        }

        private void twoBt_Click(object sender, EventArgs e)
        {
            haveZero();
            inputBox.Text += 2;
        }

        private void threeBt_Click(object sender, EventArgs e)
        {
            haveZero();
            inputBox.Text += 3;
        }

        private void fourBt_Click(object sender, EventArgs e)
        {
            haveZero();
            inputBox.Text += 4;
        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
        }

        private void removeBackBt_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
        }

        private void plusBt_Click(object sender, EventArgs e)
        {
            addSymb("+");
        }

        private void minusBt_Click(object sender, EventArgs e)
        {
            if (inputBox.Text != "")
            {
                checkInput();
                if (haveOperation() == 0)
                {
                    inputBox.Text += "-";
                } else
                {
                    calculate();
                    inputBox.Text += "-";
                }
            } else
            {
                inputBox.Text += "-";
            }
        }

        private void divideBt_Click(object sender, EventArgs e)
        {
            addSymb("/");
        }

        private void myltipleBt_Click(object sender, EventArgs e)
        {
            addSymb("*");
        }

        private void addSymb(String c)
        {
            if (inputBox.Text != "" && inputBox.Text != "-")
            {
                checkInput();
                if (haveOperation() == 0)
                {
                    inputBox.Text += c;
                }
                else
                {
                    calculate();
                    inputBox.Text += c;
                }
            }
        }

        private int haveOperation()
        {
            int ho = 0;
            string numb = inputBox.Text.Trim(new char[] { '-' });
            ho += numb.IndexOf("+") + 1;
            ho += numb.IndexOf("-") + 1;
            ho += numb.IndexOf("*") + 1;
            ho += numb.IndexOf("/") + 1;
            return ho;
        }
        private void calculateBt_Click_1(object sender, EventArgs e)
        {
            calculate();
        }

        private void haveZero()
        {
            if (inputBox.Text == "0" || inputBox.Text == "-0")
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
        }

        private void calculate()
        {
            int i = 1;
            Boolean minus = false;
            string operation = "";
            string[] numbers;
            numbers = inputBox.Text.Split(new char[] { '+', '-', '*', '/' });
            if (numbers.Length > 1)
            {
                int hm = 0;
                if (numbers.Length == 3)
                {
                    hm += 1;
                }
                string s = numbers[0 + hm];
                char[] a = s.ToCharArray(0, s.Length);
                int first = fiveToDec(numbers[0 + hm]);
                int second = fiveToDec(numbers[1 + hm]);
                if (hm == 1)
                {
                    first = first * - 1;
                }
                string[] oper = inputBox.Text.Split(new char[] { '0', '1', '2', '3', '4' });
                string str = "";
                for (int j = 0; j < oper.Length; j++)
                {
                    str += oper[j];
                }
                a = str.ToCharArray(0, str.Length);
                int pls = 0;
                if (a.Length > 1)
                {
                    pls += 1;
                }
                //switch (oper[oper.Length - 1]){
                switch (a[pls])
                {
                    case '+': 
                        inputBox.Text = decToFive(first + second);
                        break;
                    case '-':
                        inputBox.Text = decToFive(first - second);
                        break;
                    case '*':
                        inputBox.Text = decToFive(first * second);
                        break;
                    case '/':
                        inputBox.Text = decToFive(first / second);
                        break;
                    default:
                        inputBox.Text = "Error!";
                        break;
                }
            }
        }
        private string decToFive(int decNumber)
        {
            Boolean minus = false;
            if (decNumber < 0)
            {
                decNumber = Math.Abs(decNumber);
                minus = true;
            }
            if (decNumber < 5)
            {
                return decNumber + "";
            }
            string sum = "";
            while (decNumber > 0)
            {
                sum = decNumber % 5 + sum;
                decNumber /= 5;
            }
            if (minus)
            {
                sum = "-" + sum;
            }
            return sum;
        }
        private int fiveToDec(string fiveNumber)
        {
            if (Int32.Parse(fiveNumber) < 5)
            {
                return Int32.Parse(fiveNumber);
            }
            char[] numArr = fiveNumber.ToCharArray(0, fiveNumber.Length);
            int sum = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                char[] myCh = {'3'};
                myCh[0] = numArr[i];
                string s = new string(myCh);
                double d = Math.Pow(5, fiveNumber.Length - i - 1);
                sum += Int32.Parse(s) * Int32.Parse(d + "");
            }
            return sum;
        }
        private void checkInput()
        {
            switch (inputBox.Text.Remove(0, inputBox.Text.Length - 1))
            {
                case "+":
                    inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                    break;
                case "-":
                    inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                    break;
                case "*":
                    inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                    break;
                case "/":
                    inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
                    break;
            }
        }
    }
}
