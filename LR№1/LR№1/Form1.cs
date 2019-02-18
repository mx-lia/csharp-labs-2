using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_1
{
    public partial class Calculator : Form
    {
        double number;
        double result;
        bool minus = false;
        Stack<double> savedNumbers = new Stack<double>();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void control_buttons_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "С":
                    textBox1.Clear();
                    break;
                case "←":
                    int length = textBox1.TextLength;
                    if (length != 0)
                        textBox1.Text = textBox1.Text.Remove(length - 1);
                    break;
                case "save":
                    number = Convert.ToDouble(textBox1.Text);
                    savedNumbers.Push(number);
                    break;
                case "extract":
                    number = savedNumbers.Pop();
                    textBox1.Text = number.ToString();
                    break;
                case "±":
                    if (!minus)
                        textBox1.Text = textBox1.Text.Insert(0, "-");
                    else
                        textBox1.Text = textBox1.Text.Remove(0, 1);
                    break;
            }
        }

        private void input_buttons_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void operation_buttons_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToDouble(textBox1.Text);
                switch ((sender as Button).Text)
                {
                    case "√":
                        if (minus)
                            throw new Exception("Корень из отрицательного числа!");
                        result = Math.Sqrt(number);
                        break;
                    case "∛":
                        if (minus)
                            result = -Math.Pow(number, 1.0 / 3.0);
                        else
                            result = Math.Pow(number, 1.0 / 3.0);
                        break;
                    case "sin":
                        result = Math.Sin(number);
                        break;
                    case "cos":
                        result = Math.Cos(number);
                        break;
                    case "tg":
                        result = Math.Tan(number);
                        break;
                    case "ctg":
                        result = 1 / Math.Tan(number);
                        break;
                    case "x²":
                        result = number * number;
                        break;
                    case "x³":
                        result = number * number * number;
                        break;
                }
                textBox1.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] {button3, button4, button14, button17, button18, button19, button20, button21, button22, button23, button24 };

            if (textBox1.Text == "" || !textBox1.Text.Contains(",") || textBox1.Text.IndexOf(",") == textBox1.Text.Length - 1)
            {
                foreach (Button button in buttons)
                    button.Enabled = false;
                if (textBox1.Text != "" && !textBox1.Text.Contains(","))
                    button16.Enabled = true;
                else
                    button16.Enabled = false;
                if (textBox1.Text == "")
                    button2.Enabled = false;
                else
                    button2.Enabled = true;
            }
            else
            {
                foreach (Button button in buttons)
                    button.Enabled = true;
                if (savedNumbers.Count == 0)
                    button20.Enabled = false;
                else
                    button20.Enabled = true;
            }

            if (textBox1.Text.Contains("-"))
                minus = true;
            else
                minus = false;
        }
    }
}
