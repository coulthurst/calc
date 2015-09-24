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
        bool start = true;
        public double? num1 = 0.0;
        public double? num2 = 0.0;
        public double? total = 0.0;
        Operation op = new Operation();

        public void Calculate()
        {
            while (start == true)
            {
                this.CheckNumber(ref num1);
                this.CheckOperator();
                this.CheckNumber(ref num2);
                this.ExecuteOperation(symbol);
            }
            
        }
        
        public void ExecuteOperation(string symbol)
        {
                if (symbol == "+")
                {
                    total = op.Add(num1, num2);
                    Console.WriteLine(("" + num1) + " + " + ("" + num2) + " = " + ("" + (total)));
                    num1 = total;
                }
                else if (symbol == "-")
                {
                    total = op.Subtract(num1, num2);
                    Console.WriteLine(("" + num1) + " - " + ("" + num2) + " = " + ("" + (total)));
                    num1 = total;
                }
                else if (symbol == "*")
                {
                    total = op.Multiply(num1, num2);
                    Console.WriteLine(("" + num1) + " * " + ("" + num2) + " = " + ("" + (total)));
                    num1 = total;
                }
                else if (symbol == "/")
                {
                    total = op.Divide(num1, num2);
                    Console.WriteLine(("" + num1) + " / " + ("" + num2) + " = " + ("" + (total)));
                    num1 = total;
                }
                else if (symbol.ToLower() == "c")
                {
                    Console.WriteLine("Clearing");
                    num1 = 0;
                    num2 = 0;
                }
        }

        public void CheckOperator()
        {
            bool running = true;
            while(running == true)
            {
                Console.WriteLine("Enter an operator: ");
                symbol = Console.ReadLine();
                if ((symbol != "/") && (symbol != "c") && (symbol != "-") && (symbol != "*") && (symbol != "+"))
                {
                    Console.WriteLine("Invalid operator. Try entering *, /, +, -, C to clear total.");
                }
                else
                    running = false;
                
            }
        }
        public void CheckNumber(ref double? num)
        {
            bool running = true;
            while (running == true)
            {
                Console.WriteLine("Enter a number: ");
                try
                {
                    num = double.Parse(Console.ReadLine());
                    running = false;
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Try entering a number next time.");
                    running = true;
                }
                
            }
        }

    }
}
