using System;
using System.Globalization;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string s = Console.ReadLine();

            Console.WriteLine("Quantos Quartos tem na sua casa?");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] array = Console.ReadLine().Split(' ');

            string nome = array[0];
            int quartos = int.Parse(array[1]);
            double altura = double.Parse(array[2], CultureInfo.InvariantCulture);

            Console.WriteLine(s);
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
