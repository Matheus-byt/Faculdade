using System;

namespace While_com_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] num = new int[10];
            int i = num.Length - 1;
            while (i > 0)
            {
               // Console.WriteLine("CFB Cursos {0}" , i);
                num[i] = 0;
                Console.WriteLine(num[i]);
                i--;
            }
            Console.WriteLine("Fim do Loop");
        }
    }
}
