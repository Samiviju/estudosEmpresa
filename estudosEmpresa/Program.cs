using System;

namespace estudosEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Exato, está correto");
            }

            else if (a == b)
            {
                Console.WriteLine("Parabéns! Eles são iguais!");
            }

            else
            {
                Console.WriteLine("Errado");
            }







        }
    }
}