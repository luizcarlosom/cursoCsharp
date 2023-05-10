using System;
using System.Globalization;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int tentativa = int.Parse(Console.ReadLine());

            if(senha == tentativa){
                Console.WriteLine("Acesso Permitido");
            }else{
                while(senha != tentativa){
                    Console.WriteLine("Senha Invalida");
                    tentativa = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Acesso Permitido");
            }

        }
    }
}