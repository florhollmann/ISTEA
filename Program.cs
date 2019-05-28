using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // arreglo de variables /vector/matriz/array/ reservar un conj de variables agrupadas bajo un solo nombre
            /*declaracion de arreglos
            != con declaracion de variable ---> el array necesita de dos pasos para ser declarado
            
            1ro) se declara el tipo de dato de las variables que va a tener ese arreglo
            tipodedato[] nombreArray;
            2do) se pide a la memoria mediante el "NEW" (el cual pide memoria al sistema operativo para utilizar y guardar variables)
            y se declara la cantidad de variables que tendra el array

            nombreArray = new tipo[N]

             */
            float[] temperaturas;
            temperaturas = new float[10];

            string[] nombres = new string[15];

            /*nombre del arreglo[indice del arreglo]
             */
            temperaturas[4] = 32.40f;

        }
    }
}
