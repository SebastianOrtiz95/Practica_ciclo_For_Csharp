using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y calcule y emita por pantalla
            //cuántos son positivos(mayores a cero). Se debe mostrar un solo valor: el
            //conteo final.

            int n1,pos=0;
            Console.WriteLine("ingrese 20 numeros");
            for (int x = 0; x < 20; x++)
            {
                n1 = int.Parse(Console.ReadLine());
                if (n1>0)
                {
                    pos++;
                }
                
            }
            Console.WriteLine("los positivos son: " + pos);
            Console.ReadKey();
        }
    }
}
