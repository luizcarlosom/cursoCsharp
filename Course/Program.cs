using System;
using System.Globalization;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bool completo = false;
            // char genero = 'F';
            // char letra =  '\u0041';
            // byte n1 = 126;
            // int n2 = 1000;
            // int n3 = 2147483647;
            // long n4 = 2147483648L;
            // float n5 = 4.5f;
            // double n6 = 4.5;
            // string nome = "Maria Green";
            // object obj1 = "Alex Brown";
            // object obj2 = 4.5f;
            

            // Console.WriteLine(completo);
            // Console.WriteLine(genero);
            // Console.WriteLine(letra);
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
            // Console.WriteLine(n4);
            // Console.WriteLine(n5);
            // Console.WriteLine(n6);
            // Console.WriteLine(nome);
            // Console.WriteLine(obj1);
            // Console.WriteLine(obj2);

            // int n1 = int.MinValue;
            // int n2 = int.MaxValue;
            // sbyte n3 = sbyte.MinValue;
            // sbyte n4 = sbyte.MaxValue;
            // decimal n5 = decimal.MaxValue;

            //Max e Min values
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n3);
            // Console.WriteLine(n4);
            // Console.WriteLine(n5);

            // double numero = 13.35784;

            // Console.WriteLine(numero.ToString("F0"));
            // Console.WriteLine(numero.ToString("F1"));
            // Console.WriteLine(numero.ToString("F2"));
            // Console.WriteLine(numero.ToString("F3"));
            // Console.WriteLine(numero.ToString("F4"));
            // Console.WriteLine(numero.ToString("F5"));

            // //Substituir a ',' pelo '.'
            // Console.WriteLine(numero.ToString("F2", CultureInfo.InvariantCulture));

            int idade = 32;
            string nome = "Maria";
            double dinheiro = 10.35784;

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F3} reais", nome, idade, dinheiro);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {dinheiro:F3} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + dinheiro.ToString("F3", CultureInfo.InvariantCulture) + " reais");
        
        }
    }
}