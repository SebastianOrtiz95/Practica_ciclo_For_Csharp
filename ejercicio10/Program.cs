using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el
            //máximo de los números pares y el mínimo de los números impares.

            int n1,par,impar,maxPar=0,minImpar=0;
            bool banPar=false , banImpar=false ;
            Console.WriteLine("ingrese 20 numeros: ");
            for (int x = 0; x < 20; x++)
            {
                n1 = int.Parse(Console.ReadLine());
                if (n1%2==0)
                {
                    if (banPar==false)
                    {
                        maxPar = n1;
                        banPar = true;
                    }
                    else
                    {
                        if (n1>maxPar)
                        {
                            maxPar = n1;
                        }
                    }
                }
                else
                {
                    if (banImpar==false)
                    {
                       minImpar = n1;
                        banImpar=true;
                    }
                    else
                    {
                        if (n1<minImpar)
                        {
                            minImpar = n1;
                        }
                    }
                }

            }
            Console.WriteLine("el maximo de los pares fue " + maxPar);
            Console.WriteLine("el minimo de los impares fue " + minImpar);
            Console.ReadKey();  
        }
    }
}
