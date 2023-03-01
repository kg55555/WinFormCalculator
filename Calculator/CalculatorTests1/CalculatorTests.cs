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
    }
}