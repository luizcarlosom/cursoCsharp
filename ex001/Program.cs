using System;
using System.Globalization;

namespace ex001
{
    internal class Program
    {
        static void Main(string [] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            double a;
            int b;

            double c;
            float d;
            
            int e = 5;
            int f = 2;

            a = 5.1;
            b = (int)a;

            c = 6.1;
            d = (float)c;

            double resultado = (double)e / f;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1} cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2} cujo preço é $ {preco2:F2}");
            
            Console.WriteLine(" ");
            Console.WriteLine($"{idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine(" ");
            
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InstalledUICulture));

            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(resultado);

        }
    }
}