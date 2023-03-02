using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [TestMethod()]
        ///Test for checking for invalid input, in this case putting through the letter "i" through TextBoxTextChangedFunc
        public void TextBoxTextChangedFuncTest()
        {
            calculator.TextBoxTextChangedFunc("i");
            Assert.AreNotEqual("i", calculator.inputTextBox.Text);
        }

        [TestMethod()]
        ///Test for checking to see if the decimal value can appear multiple times within the textbox
        public void TextBoxTextChangedFuncTest1()
        {
            calculator.DigitButtonClickFunc(calculator.decimalButton);
            calculator.DigitButtonClickFunc(calculator.decimalButton);
            calculator.TextBoxTextChangedFunc(".");
            Assert.AreEqual(".", calculator.inputTextBox.Text);
        }

        [TestMethod()]
        ///Test for checking if the press of the 2nd button changes the button text
        public void OperatorClickFuncTest()
        {
            calculator.OperatorClickFunc(calculator.button1);
            Assert.AreEqual("π", calculator.buttonDigit4.Text);

            calculator.OperatorClickFunc(calculator.button1);
            Assert.AreEqual("4", calculator.buttonDigit4.Text);
        }


        //Tests the GetAnswer method of the ComputationProcessor class
        [TestMethod]
        public void TestGetAnswer()
        {
            ComputationProcessor test = new();

            //One Value
            Assert.AreEqual(3, test.GetAnswer(3, "="));

            //Intermediate value
            Assert.AreEqual(double.NaN, test.GetAnswer(4, "+"));

            //Two Values
            Assert.AreEqual(7, test.GetAnswer(3, "="));

        }

        //Tests the Square root input
        [TestMethod]
        public void TestSquareRoot()
        {
            calculator.inputTextBox.Text = "";
            //Negative
            calculator.DigitButtonClickFunc(calculator.buttonDigit5);
            calculator.PosNegButtonClickFunc(calculator.posNegButton);
            Assert.AreEqual(double.NaN, Math.Sqrt(Convert.ToDouble(calculator.inputTextBox.Text)));

            calculator.inputTextBox.Text = "";

            //Zero
            calculator.DigitButtonClickFunc(calculator.buttonDigit0);
            Assert.AreEqual(0, Math.Sqrt(Convert.ToDouble(calculator.inputTextBox.Text)));

            calculator.inputTextBox.Text = "";

            //Positive
            calculator.DigitButtonClickFunc(calculator.buttonDigit4);
            Assert.AreEqual(2, Math.Sqrt(Convert.ToDouble(calculator.inputTextBox.Text)));
        }

        //Tests the add memory function
        [TestMethod]
        public void TestMemory()
        {
            calculator.inputTextBox.Text = "55";
            calculator.ControlButtonClickFunc(calculator.addMemoryButton);

            calculator.inputTextBox.Text = "44";
            calculator.ControlButtonClickFunc(calculator.addMemoryButton);

            calculator.ControlButtonClickFunc(calculator.recallMemoryButton);
            Assert.AreEqual(55, Double.Parse(calculator.inputTextBox.Text));

        }
    }
}