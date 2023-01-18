using System.Text.RegularExpressions;

/// <summary>
/// Lab 2: Calculator
/// Author: Kevin Guo A01243552 Trevor Hong A01232148
/// Date: January 18, 2023 Revision: -
/// Source: Code for On/Off button from https://stackoverflow.com/questions/13446129/how-to-disable-all-controls-on-the-form-except-for-a-button
/// </summary>
namespace Calculator
{
    /// <summary>
    /// Calculator Form class containing controls and button behaviour
    /// </summary>
    public partial class Calculator : Form
    {

        private double _storedvalue = 0;
        private ComputationProcessor _processor = new();

        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls digit button behaviour by appending the digit or replacing input box with a constant
        /// </summary>
        private void DigitButtonClick(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string s = button.Text;
            if (s == "π")
            {
                inputTextBox.Text = Math.PI.ToString();
            } else if (s == "e")
            {
                inputTextBox.Text = Math.E.ToString();
            } else
            {
                inputTextBox.AppendText(s);
            }
        }

        /// <summary>
        /// Positive or negative button click handler, adds a negative sign or removes it from the beginning
        /// </summary>
        private void PosNegButtonClick(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length >= 1 && inputTextBox.Text.Substring(0, 1) == "-")
            {
                inputTextBox.Text = inputTextBox.Text[1..];
            } else
            {
                inputTextBox.Text = "-" + inputTextBox.Text;
            }
        }

        /// <summary>
        /// Santizes text input for the text box by removing illegal chars. Also removes extra periods
        /// </summary>
        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            inputTextBox.Text = Regex.Replace(inputTextBox.Text, "[^0-9-E.+∞]", "");

            string reg = ".";
            string str = inputTextBox.Text.Substring(0, inputTextBox.Text.IndexOf(reg) + reg.Length);
            inputTextBox.Text = str + inputTextBox.Text[str.Length..].Replace(reg, "");

            inputTextBox.SelectionStart = inputTextBox.TextLength;
        }


        /// <summary>
        /// Control buttons click handler
        /// </summary>
        private void ControlButtonClick(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string s = button.Text;
            string text = inputTextBox.Text;

            switch (s)
            {
                case "C":
                    inputTextBox.Clear();
                    _processor = new ComputationProcessor();
                    break;
                case "CE":
                    inputTextBox.Clear();
                    break;
                case "<-":
                    if (text.Length >= 1) inputTextBox.Text = text[..^1];
                    break;
                case "M+":
                    _storedvalue += double.Parse(inputTextBox.Text);
                    break;
                case "MR":
                    inputTextBox.Text = _storedvalue.ToString();
                    break;
                case "MC":
                    _storedvalue = 0;
                    break;
                case "OFF":
                    DisableControls(this);
                    EnableControls(onButton, false);
                    onButton.Text = "ON";
                    onButton.ForeColor = Color.Green;
                    break;
                case "ON":
                    EnableControls(this, true);
                    onButton.Text = "OFF";
                    onButton.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Operator buttons click handler
        /// </summary>
        private void OperatorClick(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            string s = button.Text;

            try
            {
                switch (s)
                {
                    case "√":
                        if (Double.Parse(inputTextBox.Text) < 0)
                        {
                            MessageBox.Show("Cannot take square root of negative number");
                            break;
                        }
                        inputTextBox.Text = Math.Sqrt(Double.Parse(inputTextBox.Text)).ToString();
                        break;
                    case "SIN":
                        inputTextBox.Text = Math.Sin(Double.Parse(inputTextBox.Text)).ToString();
                        break;
                    case "COS":
                        inputTextBox.Text = Math.Cos(Double.Parse(inputTextBox.Text)).ToString();
                        break;
                    case "TAN":
                        inputTextBox.Text = Math.Tan(Double.Parse(inputTextBox.Text)).ToString();
                        break;
                    case "1/x":
                        double x = double.Parse(inputTextBox.Text);
                        if (inputTextBox.Text == "0")
                        {
                            MessageBox.Show("Divide by 0 error");
                            break;
                        }
                        inputTextBox.Text = (1 / x).ToString();
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
                        inputTextBox.Text = _processor.GetAnswer(Double.Parse(inputTextBox.Text), s).ToString();
                        break;
                }
            } catch (FormatException)
            {
                MessageBox.Show("Number is in an incorrect format");
            } 
            
        }

        /// <summary>
        /// Form keydown event to start typing in the input box
        /// </summary>
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (ActiveControl.Name != inputTextBox.Name)
            {
                inputTextBox.Select();
                inputTextBox.AppendText(e.KeyData.ToString());
            }
           
        }

        /// <summary>
        /// Disables form buttons on load except for On button 
        /// </summary>
        private void Calculator_Load(object sender, EventArgs e)
        {
            DisableControls(this);
            EnableControls(onButton, false);
        }

        /// <summary>
        /// Disables control along with children controls, code from stack overflow
        /// </summary>
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        /// <summary>
        /// Enables control along with parent or children depending on the bool value, adapted from stack overflow
        /// </summary>
        private void EnableControls(Control con, bool all)
        {
            if (con != null)
            {
                con.Enabled = true;
                if (all)
                {
                    foreach (Control c in con.Controls) EnableControls(c , true);

                } else
                {
                    EnableControls(con.Parent, false);
                }
            }
        }
    }
}