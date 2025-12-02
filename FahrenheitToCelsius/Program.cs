using System;

namespace MyCsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FahrenheiToCelsius(135));

            Console.WriteLine("Please, enter first number");
            string operand1String=Console.ReadLine();
            int operand1Int=int.Parse(operand1String);

            Console.WriteLine("Please,enter second number");
            string operand2String=Console.ReadLine();
            int operand2Int=int.Parse(operand2String);

            int result = operand1Int + operand2Int;
            Console.WriteLine("Sum: " +result  );
        }
        static double FahrenheiToCelsius(double f)
        {
            double c = (f - 32) * 5 / 9;
            return c;
        }

    }
}
 
