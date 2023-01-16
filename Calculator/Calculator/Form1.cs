using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool nonValidCharEntered = false;

        private string storedvalue = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonValidCharEntered = false;

            Keys[] validKeys = {Keys.Left, Keys.Right, Keys.Back, Keys.Add, Keys.Subtract, Keys.Decimal, Keys.Divide,
            Keys.Multiply};


            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonValidCharEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonValidCharEntered = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonValidCharEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }

        private void buttonDigit1_Click_1(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string s = button.Text;
            string text = textBox1.Text;

            switch(s)
            {
                case "=":
                    Console.WriteLine("h");
                    break;
                case "C":
                    textBox1.Clear();
                    break;
                case "CE":
                    if (text.Length >= 1)
                    {
                        text = text.Substring(0, text.Length - 1);
                        textBox1.Text = text;
                    }
                    else
                    {
                    }
                    break;
                case "M+":
                    storedvalue = textBox1.Text;
                    break;
                case "MR":
                    textBox1.AppendText(storedvalue);
                    break;
                case "MC":
                    storedvalue = string.Empty;
                    break;
                default:
                    textBox1.AppendText(s);
                    break;
            }
        }
    }
}