using System;

namespace Calculator{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Calculator, calcular nunca foi tão fãcil!");

            // Sum();
            Subtraction();
        }

        static void Sum()
        {
            Console.WriteLine("Primeiro valor: ");
            double firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            double result = firstValue + secondValue;
            Console.WriteLine($"O resultado da soma é: {result}");
        }

        static void Subtraction()
        {
            Console.WriteLine("Primeiro valor: ");
            double firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double secondValue = double.Parse(Console.ReadLine());
            
            Console.WriteLine(" ");

            double result = firstValue - secondValue;
            Console.WriteLine($"O resultado da subtração é: {result}");
        }
    }
}