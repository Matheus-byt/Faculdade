using System;

namespace Array_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];

            nomes[0] = "Matheus";
            nomes[1] = "Robson";
            nomes[2] = "Brunno";
            nomes[3] = "Ruan";
            nomes[4] = "Fernando";
            nomes[5] = "Saulo";
            nomes[6] = "Flavio";
            nomes[7] = "Yudy";
            nomes[8] = "William";
            nomes[9] = "Kleiton";




            // ARRAY INVERTIDO //
            for (int i = nomes.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("O valor de num é na pos{0}: {1} ", i, nomes[i]);
            }


            // ARRAY INCREMENTANDO //


            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("O valor de i é na pos {0}: e nome é: {1}", i, nomes[i]);
            }
        }
    }
}
