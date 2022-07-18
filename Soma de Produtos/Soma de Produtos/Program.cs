using System;

namespace Soma_de_Produtos
{
    internal class Program
    {        
         static void Main(string[] args)
         {

                // Software que faz a soma dos 15 produtos comprados em um supermercado.
                // Desenvolvedor: Matheus Macedo
                // DATA: 22/05/2022

                int produto = 1, valor = 0, total = 0;
                int cont = 1;


                Console.WriteLine("Digite o seu nome para iniciar: ");
                string nome = Console.ReadLine();
                nome = nome.ToUpper();
              Console.Clear();


              for (produto = cont; produto <= 15; produto++)

               {
                  Console.WriteLine($"\t\t\t\t\t##### BEM VINDO (A) {nome} ##### \n");
                  Console.WriteLine("Informe o valor do " + produto + "º produto: ");
                  valor = int.Parse(Console.ReadLine());
                  Console.Clear();
                  cont++;
                  total = total + valor;
               }
             Console.WriteLine("O Valor da sua compra é: R$" + total);
         }
     }
 }

