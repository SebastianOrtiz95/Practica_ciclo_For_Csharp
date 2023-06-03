using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel
            //aclaratorio si el mismo es primo o no es primo.
            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí
            //mismo.

            int n1,cont=0;
            Console.WriteLine("ingrese un numero: ");
            n1= int.Parse(Console.ReadLine());
            for (int x = 1; x <= n1 ; x++)
            {
                if (n1%x==0)
                {
                    cont++;
                }
            }
            if (cont==2)
            {
                Console.WriteLine("el numero es primo");
            }
            else
            {
                Console.WriteLine("no es primo");
            }
            Console.ReadKey();  
        }
    }
}
