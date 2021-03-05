using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];


            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
          
            }


            Console.WriteLine("El mayor de los numeros introducidos es: "+numeros.Max());

            Console.ReadKey();
        }
    }
}
