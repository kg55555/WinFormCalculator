namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool nonValidCharEntered = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDigit1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
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
    }
}