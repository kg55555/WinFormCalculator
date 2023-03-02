using System.Diagnostics;

/// <summary>
/// Lab 2: Calculator
/// Author: Kevin Guo A01243552 Trevor Hong A01232148
/// Date: January 18, 2023 Revision: -
/// Source: N/A
/// </summary>
namespace Calculator
{
    /// <summary>
    /// Equation processing class
    /// </summary>
    public class ComputationProcessor
    {
        private double _firstNumber = double.NaN;
        private double _secondNumber = double.NaN;
        private string _prevOperation = "";

        public ComputationProcessor() { }

        /// <summary>
        /// Determines how to handle user input and selected operation
        /// </summary>
        public double GetAnswer(double num, string op) 
        {
            double answer = double.NaN;
            if (_prevOperation == "" && op != "=")
            {
                _firstNumber = num;
                _prevOperation = op;
            } else if (op != "=") {
                _secondNumber= num;
                _firstNumber = ProcessEquation(_prevOperation);
                _prevOperation = op;

            } else if (_prevOperation != "" && op == "=") { 
                _secondNumber = num;
                answer = ProcessEquation(_prevOperation);
                _firstNumber = double.NaN;
                _secondNumber= double.NaN;
                _prevOperation = "";
            } else
            {
                answer = num;
            }

            return answer;
        }

        /// <summary>
        /// Calculates answer based on the operation
        /// </summary>
        private double ProcessEquation(string op)
        {

            double answer = double.NaN;
            switch(op)
            {
                    case "+":
                    answer = _firstNumber + _secondNumber;
                    break;
                    case "-":
                    answer = _firstNumber - _secondNumber;
                    break;
                    case "*":
                    answer = _firstNumber * _secondNumber;
                    break;
                    case "/":
                        if (_secondNumber == 0)
                        {
                            MessageBox.Show("Divide by 0 error");
                            break;
                        }
                    answer = _firstNumber / _secondNumber;
                    break;
                    case "%":
                    answer = _firstNumber % _secondNumber;
                    break;
                    case "^":
                    answer = Math.Pow(_firstNumber,  _secondNumber);
                    break;

            }
            return answer;

        }

    }
}
