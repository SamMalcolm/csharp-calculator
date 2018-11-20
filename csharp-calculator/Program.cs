using System;
namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sam's Calculator App");
            Console.WriteLine("Select the first value: ");
            string Value1 = Console.ReadLine();
            int intValue1 = Int32.Parse(Value1);
            Console.WriteLine("Select the second value: ");
            string Value2 = Console.ReadLine();
            int intValue2 = Int32.Parse(Value2);
            Console.WriteLine("Select an operator (+, -, *, /): ");
            string inputOperator = Console.ReadLine();

            switch (inputOperator)
            {
                case "+":
                    int sum = intValue1 + intValue2;
                    Console.WriteLine(intValue1 + " plus " + intValue2 + " equals " + sum);
                    break;
                case "-":
                    int subtract = intValue1 - intValue2;
                    Console.WriteLine(intValue1 + " minus " + intValue2 + " equals " + subtract);
                    break;
                case "*":
                    int product = intValue1 * intValue2;
                    Console.WriteLine(intValue1 + " multiplied by " + intValue2 + " equals " + product);
                    break;
                case "/":
                    int division = intValue1 / intValue2;
                    Console.WriteLine(intValue1 + " divided by " + intValue2 + " equals " + division);
                    break;
                default:
                    Console.WriteLine("There was an error");
                    break;
            }
        }
    }
}
