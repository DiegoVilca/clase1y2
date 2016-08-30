using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int edad;
            int acumulado = 0;

            Console.Title = "Diego Vilca";

            Console.WriteLine("Hola Mundo");

            
            

            for (int i = 0; i < 5; i++)
            {
                

                
                acumulado += int.Parse(Console.ReadLine());;

                
            }

            float promedio = acumulado / 5;

            Console.WriteLine("El acumulado es: " + acumulado);


            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey(); */

            //agrego referencia del proyecto3 para usar la clase calculadora del proyecto1 (clase publica)
            //es lo mismo que agregar un using namespace
            
            Ejercicio3.Calculadora.Sumar(1,4);

            Ejercicio3.Calculadora.Dividir(10, 5);


            Console.ReadKey();
            

        }
    }
}
