using System;

namespace PrimeiroProgramaNanodegree
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            int total;

            Console.Write("Digite um número: ");
            tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {

                total = tabuada * i;
                Console.WriteLine("{0} x {1} = {2}", tabuada, i, total);
                
            }





            Console.ReadLine();

        }
    }
}
