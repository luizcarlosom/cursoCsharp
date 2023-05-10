using System;
using System.Globalization;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ");

            double a = double.Parse(array[0], CultureInfo.InvariantCulture);
            double b = double.Parse(array[1], CultureInfo.InvariantCulture);
            double c = double.Parse(array[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double triangulo = (a * c)/ 2;
            double circulo = pi * Math.Pow(c, 2);
            double trapezio = (a + b)/ 2 * c;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            System.Console.WriteLine("Triangulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Circulo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Retângulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
