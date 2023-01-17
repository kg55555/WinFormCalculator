using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class ComputationProcessor
    {
        private double firstNumber = double.NaN;
        private double secondNumber = double.NaN;
        private string prevOperation = "";

        public ComputationProcessor() { }

        public double GetAnswer(double num, string op) 
        {
            double answer = double.NaN;
            if (prevOperation == "" && op != "=")
            {
                firstNumber = num;
                prevOperation = op;
            } else if (op != "=") {
                secondNumber= num;
                answer = ProcessEquation(prevOperation);
                firstNumber = answer;
                prevOperation = op;

            } else if (prevOperation != "" && op == "=") { 
                secondNumber = num;
                answer = ProcessEquation(prevOperation);
                firstNumber = double.NaN;
                secondNumber= double.NaN;
                prevOperation = "";
            } else
            {
                answer = num;
            }

            return answer;
        }

        private double ProcessEquation(string op)
        {
            checked
            {

            double answer = 0;
            switch(op)
            {
                    case "+":
                    answer = firstNumber + secondNumber;
                    break;
                    case "-":
                    answer = firstNumber - secondNumber;
                    break;
                    case "*":
                    answer = firstNumber * secondNumber;
                    break;
                    case "/":
                    answer = firstNumber / secondNumber;
                    break;
                    case "%":
                    answer = firstNumber % secondNumber;
                    break;
                    case "^":
                    answer = Math.Pow(firstNumber,  secondNumber);
                    break;

            }
                Trace.WriteLine(answer);
            return answer;

            }
        }

    }
}
