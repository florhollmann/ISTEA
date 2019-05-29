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
            temperaturas[0] = 27.15f;
            nombres[14] = "Jose";
            nombres[6] = "Paula";


            Console.WriteLine(temperaturas[0]);
            Console.WriteLine(nombres[6]);

            /*como inicializar un arreglo!!
             
            En vez de pedirle memoria al sistema con NEW -por ejemplo avisarle que necesito 15 espacios y no definirlos,
            directamente los defino en el mismo renglon

            Cuando printeas el nombre de un array te muestr >>> direccion de memoria donde se encuentran esas variables
            pero no su contenido
             */

            int[] nums = { 27, -1001, 952, 188, -3, 2704, 303 };

            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ", ");

            }

            Console.WriteLine("\n --------------");

            char[] origen = { 'x', '&', '5', '*', 'A', 'q' };
            char[] destino = new char[origen.Length];

            /*destino = origen;
            Console.WriteLine(destino[3]);

            destino[2] = 'R';
            Console.WriteLine(origen[2]);

            !!ESTO QUE HICIMOS ARRIBA NO COPIA UN ARREGLO!!! solamente guarda en la misma direccion de memoria ambos arreglos, entonces
             * cuando modifico el arreglo de destino , se modifica tmb el de origen porque estan situados en la misma porcion de memoria!*/

            //Para copiar un arreglo: copiar lo que hay en la primer variable de origen a la primer variable de destino

            for (int i = 0; i < origen.Length; i++)
            {
                destino[i] = origen[i];
                Console.Write(destino[i] + ", ");

            }

            byte[] vec = { 15, 28, 250, 99, 6, 177, 23, 99 };
            byte numIngresado, numMenor = byte.MaxValue;
            short suma = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                suma += vec[i];
            }

            Console.WriteLine("Promedio: {0}", suma / vec.Length);

            Console.WriteLine("Ingrese un numero");
            numIngresado = byte.Parse(Console.ReadLine());

            for (int i = 0; i < vec.Length; i++)
            {
                if (numIngresado == vec[i])
                    Console.WriteLine("El arreglo se encuentra en la posicion {0}", i);
            }

           

            //copiar el contenido de un arreglo a otro en forma invertida


            byte[] vecInvertido = new byte[vec.Length];
            int indiceFinal = vecInvertido.Length - 1;

            for (int i = 0; i < vecInvertido.Length; i++)
            {
                vecInvertido[indiceFinal - i] = vec[i];
                Console.WriteLine(vecInvertido[i]);
            }

            /*opcion numero2*/
            for (int i = 0, j = vecInvertido.Length - 1; i < vec.Length; i++, j--)
            {
                vecInvertido[j] = vecInvertido[i];
            }

            // COMO AMPLIAR EL TAMAÑO DE UN ARRAY!!!!!!! 

            byte dimensionArray;
            Console.WriteLine("Que dimension quiere que tenga el arreglo?");
            dimensionArray = byte.Parse(Console.ReadLine());

            byte[] vecAux = new byte[dimensionArray];

            for (int i = 0; i < vec.Length; i++)
            {
                vecAux[i] = vec[i];
            }
            
            //AHORA QUE TENGO UN VECTOR AUXILIAR CON MAS ESPACIOS DE MEMORIA QUE VEC, REASIGNO EL NOMBRE VEC, AL VEC AUXILIAR
            vecAux = vec;

            //imprimir el vec redimensionado
            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            }
            
            
            //encontrar numero menor
            for (int i = 0; i < vec.Length; i++)
                {
                if (vec[i] < numMenor)
                    numMenor = vec[i];
            }
            Console.WriteLine("El numero menor es {0}", numMenor);
        }
    }
}
