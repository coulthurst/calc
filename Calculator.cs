using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator
    {
        
        string symbol;
        bool running = true;
        bool start = true;
        public double? num1 = null;
        public double? num2 = null;
        public double? total = null;
        Operation op = new Operation();

        public void Calculate()
        {
            while (start)
            {
                this.CheckNumber(ref num1);

                while (running)
                {
                    this.OperatorErrorCheck();
                    this.CheckNumber(ref num2);
                    this.ExecuteOperation(symbol);
                }

            }
        }
        
        public void ExecuteOperation(string symbol)
        {
            if (symbol == "+")
            {
                total = op.Add(num1, num2);
                Console.WriteLine("Total : " + ("" + (total)) + " I hope you're proud of yourself. You disgust me.");
                num1 = total;
            }
            else if (symbol == "-")
            {
                total = op.Subtract(num1, num2);
                Console.WriteLine("Total : " + ("" + (total)) + " I hope you're proud of yourself. You disgust me.");
                num1 = total;
            }
            else if (symbol == "*")
            {
                total = op.Multiply(num1, num2);
                Console.WriteLine("Total : " + ("" + (total)) + " I hope you're proud of yourself. You disgust me.");
                num1 = total;
            }
            else if (symbol == "/")
            {
                total = op.Divide(num1, num2);
                Console.WriteLine("Total : " + ("" + (total)) + " I hope you're proud of yourself. You disgust me.");
                num1 = total;
            }
            else
            {
                Console.WriteLine("Invalid operator. Try entering *, /, +, -, C to clear total or Q to exit.");
                num2 = null;
            }
        }

        public void OperatorErrorCheck()
        {
            Console.WriteLine("Enter an operator you filthy animal: ");
            try
            {
                symbol = Console.ReadLine();
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Invalid operator.");
            }
            if (symbol.ToLower() == "q")
            {
                start = false;
            }
            if (symbol.ToLower() == "c")
            {
                running = false;
            }
        }
        public void CheckNumber(ref double? num)
        {
            Console.WriteLine("Yo, Enter a number: ");
            try
            {
                num = double.Parse(Console.ReadLine());
                running = true;
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Try entering a number next time.");
                running = false;
            }
        }
    }
}
