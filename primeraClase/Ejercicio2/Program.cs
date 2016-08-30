using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();

            int numeroRamdom;

            int contador = 0;
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            int contador4 = 0;
            int contador5 = 0;
            int contador6 = 0;
            int contador7 = 0;
            int contador8 = 0;
            int contador9 = 0;
            int contador10 = 0;
            
            int total = 100000;

            //Console.WriteLine("Numero random: "+ numeroRamdom);

            //Console.ReadKey();

            for ( ; contador < total; )
            {
                contador++;

                numeroRamdom = random.Next(1, 11);

                Console.WriteLine(numeroRamdom);

                switch (numeroRamdom)
                {
                    case 1: contador1++;
                            break;
                    case 2: contador2++;
                            break;
                    case 3: contador3++;
                            break;
                    case 4: contador4++;
                            break;
                    case 5: contador5++;
                            break;
                    case 6: contador6++;
                            break;
                    case 7: contador7++;
                            break;
                    case 8: contador8++;
                            break;
                    case 9: contador9++;
                            break;
                    case 10: contador10++;
                            break;
                
                }
            }

            Console.WriteLine("1: " + ((contador1 * 100)/ total) + "%");
            Console.WriteLine("2: " + ((contador2 * 100) / total) + "%");
            Console.WriteLine("3: " + ((contador3 * 100) / total) + "%");
            Console.WriteLine("4: " + ((contador4 * 100) / total) + "%");
            Console.WriteLine("5: " + ((contador5 * 100) / total) + "%");
            Console.WriteLine("6: " + ((contador6 * 100) / total) + "%");
            Console.WriteLine("7: " + ((contador7 * 100) / total) + "%");
            Console.WriteLine("8: " + ((contador8 * 100) / total) + "%");
            Console.WriteLine("9: " + ((contador9 * 100) / total) + "%");
            Console.WriteLine("10: " + ((contador10 * 100) / total) + "%");
            
            Console.ReadKey();
            

            
        }
    }
}
