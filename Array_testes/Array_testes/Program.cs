using System;

namespace Array_testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomePessoas = new string[10];

            nomePessoas[0] = "Acassio";
            nomePessoas[1] = "Ronaldo";
            nomePessoas[2] = "Francisco";
            nomePessoas[3] = "Fernando";
            nomePessoas[4] = "Beatriz";
            nomePessoas[5] = "Gustavo";
            nomePessoas[6] = "Marcos";
            nomePessoas[7] = "Luan";
            nomePessoas[8] = "Agnaldo";
            nomePessoas[9] = "Flavio";

            int[] Numeros = new int[10];

            Numeros[0] = 0;
            Numeros[1] = 1;
            Numeros[2] = 2;
            Numeros[3] = 3;
            Numeros[4] = 4;
            Numeros[6] = 5;
            Numeros[7] = 6;
            Numeros[8] = 7;
            Numeros[9] = 8;




            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Nome: " + i);
            //    Console.WriteLine(nomePessoas[i]);

            //}

            foreach (var nome in nomePessoas)
            {
                Console.WriteLine("O nome " + Numeros[0]++ + " é: ") ;
                Console.WriteLine(nome);
            }
        }
    }
}
