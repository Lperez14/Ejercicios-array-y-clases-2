using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercico3
    {
        static void Main(string[] args)
        {

            int[] dias = new int[13];

            dias[1] = 31;
            dias[2] = 28;
            dias[3] = 31;
            dias[4] = 30;
            dias[5] = 31;
            dias[6] = 30;
            dias[7] = 31;
            dias[8] = 31;
            dias[9] = 30 ;
            dias[10] = 31 ;
            dias[11] = 30;
            dias[12] = 31 ;

            Console.WriteLine("Digite el numero del mes");
            Console.WriteLine("1-Enero");
            Console.WriteLine("2-Febrero");
            Console.WriteLine("3-Marzo");
            Console.WriteLine("4-Abril");
            Console.WriteLine("5-Mayo");
            Console.WriteLine("6-Junio");
            Console.WriteLine("7-Julio");
            Console.WriteLine("8-Agosto");
            Console.WriteLine("9-Septiembre");
            Console.WriteLine("10-Octubre");
            Console.WriteLine("11-Noviembre");
            Console.WriteLine("12-Diciembre");
            Console.Write("Digies el numero: ");
            int numero = int.Parse(Console.ReadLine());
            

            Console.WriteLine("El numero de dias que tiene el mes que selecciono es: "+dias[numero]);

            Console.ReadKey();
         
        }
    }
}
