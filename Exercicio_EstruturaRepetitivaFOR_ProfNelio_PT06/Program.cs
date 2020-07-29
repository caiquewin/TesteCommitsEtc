using System;

namespace Exercicio_EstruturaRepetitivaFOR_ProfNelio_PT06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coloque um numero que mostraremos todos divisores por ele !");
            int valor = int.Parse(Console.ReadLine());
            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Bom dia, tudo  bem com você ?");
            string teste = Console.ReadLine();
            Console.WriteLine("se vc esta "+teste+" eu tambem estou");
            Console.WriteLine("tenha um bom dia");
        }
    }
}
