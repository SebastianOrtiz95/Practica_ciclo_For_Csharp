using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Hacer un programa que solicite el ingreso de 10 números y que muestre el
            //    mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int n1,max=0;
            Console.WriteLine("ingrese 10 numeros");
            for (int x = 0; x < 10; x++)
            {
                n1 = int.Parse(Console.ReadLine());

                if (x==0)
                {
                    max=n1;
                }
                else
                {
                    if (n1>max)
                    {
                        max= n1;    
                    }
                }
            }
            Console.WriteLine("el mayor numero ingresado fue " + max);
            Console.ReadKey();
        }
    }
}
