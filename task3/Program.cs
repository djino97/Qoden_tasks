using System;
using System.Collections.Generic;


    class Program
    {
        private String inputArg;
        private static Stack<int> stackNumber = new Stack<int>();

        static void Main()
        {

            var inputArg = Console.ReadLine().Split(" ");
            Program instanceProg = new Program();

            foreach (var arg in inputArg)
                instanceProg.CalculationPostfixExpression(arg);

            Console.WriteLine(stackNumber.Pop());
        }

        private void CalculationPostfixExpression(String inputArg)
        {
            this.inputArg = inputArg;
            int numberFromInputString;
            bool isNumber = int.TryParse(inputArg, out numberFromInputString);

            if (isNumber)
                stackNumber.Push(numberFromInputString);
            else
                TheOperationDefinition();
        }

        private void TheOperationDefinition()
        {
            int operand2;
            int calcExpression;

            switch (inputArg)
            {
                case "+":
                    calcExpression = stackNumber.Pop() + stackNumber.Pop();
                    stackNumber.Push(calcExpression);
                    break;

                case "*":
                    calcExpression = stackNumber.Pop() * stackNumber.Pop();
                    stackNumber.Push(calcExpression);
                    break;

                case "-":
                    operand2 = stackNumber.Pop();
                    calcExpression = stackNumber.Pop() - operand2;

                    stackNumber.Push(calcExpression);
                    break;

                case "/":
                    operand2 = stackNumber.Pop();
                    calcExpression = stackNumber.Pop() / operand2;

                    stackNumber.Push(calcExpression);
                    break;

                default:
                    break;
            }
        }
    }

