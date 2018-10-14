using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple math

            Console.WriteLine("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double sum = firstNumber + secondNumber;
            double prod = firstNumber * secondNumber;
            double sub = firstNumber - secondNumber;
            double div = firstNumber / secondNumber;
            double rem = firstNumber % secondNumber;

            Console.WriteLine("Addition: {0}", sum);
            Console.WriteLine("Product: {0}", prod);
            Console.WriteLine("Subtraction: {0}", sub);
            Console.WriteLine("Division: {0}", div);
            Console.WriteLine("Remainder: {0}", rem);

            //Keeps the console Open
            Console.ReadKey();
        }
    }
}
