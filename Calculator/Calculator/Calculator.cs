using Accessibility;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Calculator : Form
    {

        private string storedvalue = string.Empty;
        private ComputationProcessor processor = new ComputationProcessor();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void DigitButtonClick(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string s = button.Text;
            if (s == "π")
            {
                textBox1.AppendText(Math.PI.ToString());
            }
            if (s == "e")
            {
                textBox1.AppendText(Math.E.ToString());
            }
            textBox1.AppendText(s);
        }

        private void PosNegButtonClick(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1 && textBox1.Text.Substring(0, 1) == "-")
            {
                textBox1.Text = textBox1.Text[1..];
            } else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Regex.Replace(textBox1.Text, "[^0-9-E.+∞]", "");

            string reg = ".";
            string str = textBox1.Text.Substring(0, textBox1.Text.IndexOf(reg) + reg.Length);
            textBox1.Text = str + textBox1.Text[str.Length..].Replace(reg, "");

            textBox1.SelectionStart = textBox1.TextLength;
        }



        private void ControlButtonClick(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string s = button.Text;
            string text = textBox1.Text;

            switch (s)
            {
                case "C":
                    textBox1.Clear();
                    processor = new ComputationProcessor();
                    break;
                case "CE":
                    textBox1.Clear();
                    break;
                case "<-":
                    if (text.Length >= 1) textBox1.Text = text[..^1];
                    break;
                case "M+":
                    storedvalue = textBox1.Text;
                    break;
                case "MR":
                    textBox1.Text = storedvalue;
                    break;
                case "MC":
                    storedvalue = string.Empty;
                    break;
                default:
                    break;
            }
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string s = button.Text;

            try
            {
                switch (s)
                {
                    case "√":
                        if (Double.Parse(textBox1.Text) < 0)
                        {
                            MessageBox.Show("Cannot take square root of negative number");
                            break;
                        }
                        textBox1.Text = Math.Sqrt(Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "SIN":
                        textBox1.Text = Math.Sin(Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "COS":
                        textBox1.Text = Math.Cos(Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "TAN":
                        textBox1.Text = Math.Tan(Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "1/x":
                        double x = double.Parse(textBox1.Text);
                        if (textBox1.Text == "0")
                        {
                            MessageBox.Show("Divide by 0 error");
                            break;
                        }
                        textBox1.Text = (1 / x).ToString();
                        break;
                    case "2nd":
                        if (buttonDigit4.Text == "4")
                        {
                            buttonDigit4.Text = "π";
                            buttonDigit5.Text = "e";
                            label2.Text = "4";
                            label3.Text = "5";
                        } else
                        {
                            buttonDigit4.Text = "4";
                            buttonDigit5.Text = "5";
                            label2.Text = "π";
                            label3.Text = "e";
                        }
                        break;
                    case "/":

                    default:
                        textBox1.Text = processor.GetAnswer(Double.Parse(textBox1.Text), s).ToString();
                        break;
                }
            } catch (FormatException)
            {
                MessageBox.Show("Number is in an incorrect format");
            } 
            
        }
    }
}