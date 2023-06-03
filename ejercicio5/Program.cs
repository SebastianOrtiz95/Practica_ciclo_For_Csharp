using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que muestre los números del 1 al 100 de 5 en 5.Ejemplo:
            //0, 5, 10, 15, 20....100.

            for (int x = 0; x < 101; x++)
            {
                if (x%5==0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
