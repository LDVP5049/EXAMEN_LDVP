using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_LDVP.Metodos
{
    internal class Ejercicios
    {
        public void CienNum()
        {

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26, 25, 26, 27, 28, 29, 30, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 75, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 67, 66, 68, 69, 70, 71, 72, 73, 74, 75, 76, 78, 77, 79, 80, 88, 81, 82, 83, 84, 85, 86, 87, 89, 90, 91, 92, 94 };
            Console.WriteLine("Matriz desordenada");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            int menor = 0;
            int pos = 0;
            int temp = 0;

            for (int i = 0; i < numeros.Length - 1;i++) 
            { 
                menor = numeros[i];
                pos= i;
                for (int j= i+1; j < numeros.Length; j++)
                {
                    if (numeros[j] < menor) 
                    {
                        menor = numeros[j];
                        pos= j;
                    }
                    if (pos != i)
                    {
                        temp= numeros[i];
                        numeros[i] = numeros[pos];
                        numeros[pos] = temp;
                    }
                }
            }
            Console.WriteLine("Numeros ordendos");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("Mas grande al numero mas chico");
            for (int i = numeros.Length -1 ; i >= 0; i--) 
            {
                Console.WriteLine(numeros[i]);
            }

        }

        public void Binaria()
        {
            Console.WriteLine("Numero a buscar");
            int valorBuscar = Convert.ToInt32(Console.ReadLine());


            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26, 25, 26, 27, 28, 29, 30, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 75, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 67, 66, 68, 69, 70, 71, 72, 73, 74, 75, 76, 78, 77, 79, 80, 88, 81, 82, 83, 84, 85, 86, 87, 89, 90, 91, 92, 94 };
            Console.WriteLine("Matriz desordenada");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            int n = numeros.Length;
            int inf = 0;
            int centro = 0;
            int sup = n - 1;
            bool bandera = false;

            while (inf <= sup)
            {
                centro = (sup + inf) / 2;
                if (numeros[centro] == valorBuscar) 
                {
                    bandera = true;
                    break;
                }
                else if (valorBuscar < numeros[centro])
                {
                    sup = centro - 1;
                }
                else
                {
                    inf = centro + 1;
                }
            }
            if (bandera == true) 
            {
            Console.WriteLine($"El numero {valorBuscar} está en {centro + 1}");
            }
            else
            {
                Console.WriteLine("Nombre pues no está");
            }

        }
    }
}
/*Random random = new Random();
int[] numeros = new int[100];
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(0, 100);
}*/
