using System;

namespace Altura_média_entre_5_pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            float altura, alturasoma = 0, mda;

            for (i=1; i <= 5; i++)
            {
                Console.Write($"Digite a altura da {i}º pessoa: ");
                altura = float.Parse(Console.ReadLine());
                alturasoma = alturasoma + altura;
            }
            mda = alturasoma / 5;
            Console.WriteLine($"A média da altura entre as 5 pessoas é: {mda}");
        }
    }
}
