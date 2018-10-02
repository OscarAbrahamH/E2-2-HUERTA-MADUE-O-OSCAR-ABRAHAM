using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Fibonacci
{
    class PROGRAMAFIBONACCI
    {
        public int a;
        public int b;
        public int c;
        public int i;
        public int aux;

        public void ValorDatos()
        {
            Console.Write("Numero Fibonacci: ");
            c = int.Parse(Console.ReadLine());
        }

        public void Proceso()
        {

            a = 0;
            b = 1;
            for (i = 0; i < c; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Serie Fibonacci: ");
        }

        static void Main(string[] args)
        {


            PROGRAMAFIBONACCI figura1 = new PROGRAMAFIBONACCI();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            figura1.ValorDatos();
            figura1.Imprimir();
            figura1.Proceso();

            Console.WriteLine("-------------------------------");
            stopWatch.Stop();
            Console.WriteLine("Proceso Finalizado en " +
            stopWatch.Elapsed.ToString(), "Mensaje Sistema");
            Console.ReadKey();




        }
    }
}
