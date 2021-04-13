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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Num1Box.Text == "" 
                || Num2Box.Text == "" 
                || comboBox1.Text == ""
                || double.TryParse(Num1Box.Text, out double result) == false
                || double.TryParse(Num2Box.Text, out double result2) == false)
                AnswerBox.Text = "Error";
            else
            {
                double FirstNum = Convert.ToDouble(Num1Box.Text);
                double SecondNum = Convert.ToDouble(Num2Box.Text);

                switch (comboBox1.Text)
                {
                    case "+":
                        AnswerBox.Text = Convert.ToString(FirstNum + SecondNum);
                        break;
                    case "-":
                        AnswerBox.Text = Convert.ToString(FirstNum - SecondNum);
                        break;
                    case "*":
                        AnswerBox.Text = Convert.ToString(FirstNum * SecondNum);
                        break;
                    case "/":
                        if (SecondNum == 0)
                            AnswerBox.Text = "Error";
                        else
                            AnswerBox.Text = Convert.ToString(FirstNum / SecondNum);
                        break;
                    default:
                        break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Num1Box.Text = null;
            Num2Box.Text = null;
            AnswerBox.Text = null;
            comboBox1.Text = null;
        }
    }
}
