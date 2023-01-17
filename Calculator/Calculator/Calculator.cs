using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

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
                textBox1.Text = processor.GetAnswer(Double.Parse(textBox1.Text), s).ToString();
            } catch (FormatException)
            {
                MessageBox.Show("Number is in an incorrect format");
            }

            
            
            
        }
    }
}