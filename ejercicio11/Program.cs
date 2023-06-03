using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
            //de los primos de la lista. En caso de no haber ningún número primo, deberá
            //aclararlo con un cartel.

            int n1,maxPrimo=0;
            bool ban = false;   
            Console.WriteLine("ingrese 10 numeros");
            for (int x = 0; x < 10; x++)
            {
                n1 = int.Parse(Console.ReadLine());
                int cont = 0;
                for (int y = 1; y <=n1; y++)
                {
                    if (n1%y==0)
                    {
                        cont++;
                    }
                }
                if (cont==2)
                {
                    if (n1>maxPrimo)
                    {
                        maxPrimo = n1;
                        ban = true;
                    }
                }
            }
            if (ban==true)
            {
                Console.WriteLine(" el mayor numero primo ingresado fue " + maxPrimo);
            }
            else
            {
                Console.WriteLine(" no se ingresaron numeros primos ");
            }
            Console.ReadKey();
        }
    }
}
