using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Otro.Calculadora.Sumar();

            Console.WriteLine(Calculadora.Sumar(6, 6));

            Console.WriteLine(Calculadora.Dividir(0, 0));

            Alumno alguien;

            alguien = new Alumno();

            Alumno otro = new Alumno();

            otro.nombre = "Maria";

            alguien.nombre = "Jose";

            otro.MostrarDatos();

            alguien.MostrarDatos();

            

            Console.ReadKey();
        }
    }
}
