using System;
using System.Globalization;

namespace ex003
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o valor do raio de um círculo: ");
            
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine(raio);
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
