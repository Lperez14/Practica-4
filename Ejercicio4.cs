using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {

            /**/

            char abecedario = 'A';
            
            do
            {
                Console.WriteLine(abecedario);
                abecedario++;

            }
            while (abecedario <= 'Z');

            Console.ReadKey();


        }
    }
}
