using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Calculadora
    {

        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }



        public static int Dividir (int numero1, int numero2)
        {
            if (Calculadora.ValidarSiEsCero(numero2))
                return 0;
                return numero1 / numero2;

            /*if (numero2 == 0)
                return 0;
            else
                return numero1 / numero2;*/
        }



        private static bool ValidarSiEsCero(int numero)
        {
            
            if (numero == 0)
                return true;
            //else    //El if funciona igual sin el else
                return false;
        }

        /// <summary>
        /// Me devuelve true si el numero ingresado supera el limite
        /// </summary>
        /// <param name="limite">Este es el limite que debe ser superado</param>
        /// <param name="numero">Este es el numero que debemos verificar si supera el limite</param>
        /// <returns></returns>
        public static bool EsMayorQue(int limite, int numero)
        {
            if (numero > limite)
                return true;
                return false;
        }


        private static bool ValidarSiEsPar(int numero)
        {
            if (numero % 2 == 0)
                return true;
                return false;
            
        }
    }
}



namespace Otro
{
    public class Calculadora
    {
        public static void Sumar()
        {

        }
    }
}
