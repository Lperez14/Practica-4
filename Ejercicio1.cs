using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            /*Ejercicio 1*/
            int numero = 1,total = 0;
            do
            {
                Console.Write("Digite un numero: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > 0)
                {
                    total += numero;
                } 
               
                
            } while (numero >= 1);

            Console.WriteLine("La suma total de los numero introducidos es: " + total);

            Console.ReadKey();
        }
    }
}
