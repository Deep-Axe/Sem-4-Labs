using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Calc
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendNumber(string number)
        {
            if (textBox1.Text == "0" || isOperationPerformed)
                textBox1.Clear();

            isOperationPerformed = false;
            textBox1.Text += number;
        }

        private void x_square_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(double.Parse(textBox1.Text), 2)).ToString();
        }

        private void x_cube_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(double.Parse(textBox1.Text), 3)).ToString();
        }

        private void Reciprocal_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
        }

        private void Natural_Log_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) / 100).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num_sign_button_Click(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(textBox1.Text, out number))
            {
                textBox1.Text = (-number).ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void clear_everything_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void Logarithm_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Log10(double.Parse(textBox1.Text))).ToString();
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            try{ 
                Button button = (Button)sender;
                operation = button.Text;

                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    result = double.Parse(textBox1.Text);
                }
                else
                {
                    result = 0; 
                }

                isOperationPerformed = true;

                
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sinh(double.Parse(textBox1.Text)).ToString();
        }

        private void Sine_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBox1.Text.StartsWith("0b")) // Binary
                {
                    textBox1.Text = Convert.ToInt32(textBox1.Text.Substring(2), 2).ToString();
                }
                else if (textBox1.Text.StartsWith("0x")) // Hexadecimal
                {
                    textBox1.Text = Convert.ToInt32(textBox1.Text.Substring(2), 16).ToString();
                }
                else if (textBox1.Text.StartsWith("0o")) // Octal
                {
                    textBox1.Text = Convert.ToInt32(textBox1.Text.Substring(2), 8).ToString();
                }
                
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
            }
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void zero_button_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void decimal_point_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
            }
            else if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void equal_to_button_Click(object sender, EventArgs e)
        {
            double secondNumber = Double.Parse(textBox1.Text);
            switch (operation)
            {
                case "+": textBox1.Text = (result + secondNumber).ToString(); break;
                case "-": textBox1.Text = (result - secondNumber).ToString(); break;
                case "*": textBox1.Text = (result * secondNumber).ToString(); break;
                case "/": textBox1.Text = (result / secondNumber).ToString(); break;
                case "Mod": textBox1.Text = (result % secondNumber).ToString(); break;
                case "Exp": textBox1.Text = Math.Exp(secondNumber).ToString(); break;
            }
            isOperationPerformed = false;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void Binary_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text), 2);
        }

        private void Cosine_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cosh(double.Parse(textBox1.Text)).ToString();
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tanh(double.Parse(textBox1.Text)).ToString();
        }

        private void Tangent_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(double.Parse(textBox1.Text)).ToString();
        }

        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text), 16).ToUpper();
        }

        private void Exponential_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }

        private void Octal_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text), 8);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
