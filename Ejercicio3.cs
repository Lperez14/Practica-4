using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            /*Ejercicio 3*/
            int  primeros= 1;

            for (int numero = 100; primeros <= 10 ; numero--)
            {
                if(numero % 2 == 0)
                {
                    Console.WriteLine( primeros + "- "+numero);
                    primeros++;
                        
                } 
            }
            Console.ReadKey();

        }
    }
}
