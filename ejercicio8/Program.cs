using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego mostrar por pantalla el
            //menor de ellos y la posición en la que fue encontrado.

            int n1, men = 0, pos = 1;
            Console.WriteLine("ingrese 10 numeros");
            for (int x = 0; x < 10; x++)
            {
                n1 = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    men = n1;
                    pos = 1;
                }
                else
                {
                    if (n1 < men)
                    {
                        men = n1;
                        pos = x + 1;
                    }
                }
            }
            Console.WriteLine("el mayor de los numeros ingresados fue {0} y su posicion fue el {1}° lugar", men, pos);
            Console.ReadLine();
        }
    }
}
