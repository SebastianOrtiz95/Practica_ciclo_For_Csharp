using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
            //de aquellas personas mayores a 18 años.

            int edad=0;
            float promedio=0,acum=0,cont=0;
            Console.WriteLine("ingrese 20 edades");
            for (int x = 0; x < 20; x++)
            {
                edad = int.Parse(Console.ReadLine());
                if (edad>18)
                {
                    acum+=edad;
                    cont++;
                }
            }
            promedio = acum/cont;
            if (acum!=0)
            {
                Console.WriteLine("el promedio de edad de mayores a 18 años es : " + promedio);
            }
            else
            {
                Console.WriteLine("no se registraron mayores a 18 años");
            }
            Console.ReadLine();
        }
    }
}
