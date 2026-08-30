using System.Diagnostics.CodeAnalysis;
using System.IO.Enumeration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_11_Hamilton_Cuevas_1190526
{      // clase progrema 
    internal class Program
    {   //declaracion del arreglo de numero actividad 1
        static int[] arregloNumeros = new int[5];
        //metodo para llenar el arreglo
        static private void Actividad1()
        {
            Console.WriteLine("Ejercicio 1: areglos unidemensionales");
            Console.WriteLine("hecho por Hamilton Cuevas 1190526");
            int Suma = 0;
            for (int i = 0; i < arregloNumeros.Length; i++)
            {
                Console.WriteLine("ingrese un numero para llenar el arreglo: ");
                arregloNumeros[i] = int.Parse(Console.ReadLine());
            }
            //imprimer los datos del arreglo
            foreach (int numero in arregloNumeros)
            {

                Console.WriteLine(numero);
                Suma += numero;

            }

            Console.WriteLine("La suma de los elementos del arreglo es: " + Suma);
            Console.WriteLine("El promedio de los elemntos del los numeros en el arreglo es: " + Suma / arregloNumeros.Length);


        }
        //separar caracteres mediante la funcion split 
        static void Actividad2()
        {
            Console.WriteLine("Ejercicio 2: Separa caracteres con la funcion split");
            Console.WriteLine("hecho por Hamilton Cuevas 1190526");
            Console.WriteLine("Ingrese el Codigo de la casa; ");
            string codigoCasa = Console.ReadLine();

            string[] DatosCasa = codigoCasa.Split('-');
            string manzana = DatosCasa[0];
            int numeroCasa = int.Parse(DatosCasa[1]);
            Console.WriteLine("La manzano es: " + manzana);
            Console.WriteLine("El numero de la casa es: " + numeroCasa);
        }

        static private void Actividad3()
        {   int suma = 0;
            Console.WriteLine("ejercicio 3: Arreglo con numeros aleatorios");
            Console.WriteLine("Hecho por Hamilton Cuevas 1190526");
            Random random = new Random();

            int[] arregloAleatorios = new int[10];
            for (int i = 0; i < arregloAleatorios.Length; i++)
            {
                arregloAleatorios[i] = random.Next(1, 6);
                Console.WriteLine(arregloAleatorios[i]);
                Console.WriteLine("");
            }
            for (int i = 0; i < arregloAleatorios.Length; i++)
            {
                arregloAleatorios[i] = random.Next(1, 5);
                if (arregloAleatorios[i] % 2 != 0)
                {
                    Console.WriteLine($"El numero {arregloAleatorios[i]} es impar");
                    suma += arregloAleatorios[i];
                }
               
            }
            Console.WriteLine($"La suma de los impares en el arreglo es: {suma} ");


        }

            static void Main(string[] args)
            {
                Actividad3();
            }
    }
}
