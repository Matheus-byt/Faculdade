using System;

namespace Soma_de_1_a_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolvedor: Matheus Macedo
            //Data: 29/05/2022
            //Objetivo: Programa que calcula de 1 à 10.

            int i;
            float vf = 0;

            for (i=1; i <= 10; i++)
            {
                vf = vf + i;
                Console.WriteLine($"A soma da {i} é: {vf}");
                Console.Write("");
            }
            Console.WriteLine($"\nO resultado da somatoria dos números de 1 à 10 é: {vf}");
        }
    }
}
