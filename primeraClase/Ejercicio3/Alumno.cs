using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno
    {
        public string nombre; //variables en una clase = atributos
        public int nota;
         //Los atributos de inicializan solos menos los que son de referencia (instanciados)

        public void MostrarDatos()
        {
            Console.WriteLine(this.nombre);  //This se usa solo con instancias 

            Console.WriteLine(this.nota);
        }

        
        //static
        public static bool CompararAlumnos(Alumno uno, Alumno dos) //en static no se utiliza el .this
        {
            if (uno.nombre == dos.nombre)
            
                return true;
                return false;
            
        }
        //de instancia
        public bool Compararme(Alumno otro)
        { 
                if(this.nombre == otro.nombre)
                return true;
                return false;
        }

        


        //Ejemplos de reutilizacion de codigo

        //Opcion uno
        // Reutilizo el metodo Compararme


        /*
        public static bool CompararAlumnos(Alumno uno, Alumno dos)
        {
            return uno.Compararme(dos) ;

        }

        public bool Compararme(Alumno otro)
        {
            if (this.nombre == otro.nombre)
                return true;
                return false;
        }
         */

        //Opcion dos
        // Reutilizo el metodo CompararAlumno

        /*
        public static bool CompararAlumnos(Alumno uno, Alumno dos) //en static no se utiliza el .this
        {
            if (uno.nombre == dos.nombre)

                return true;
            return false;

        }

        public bool Compararme(Alumno otro)
        {
            return CompararAlumnos(this, otro);
        }
        */



        
    }
}
