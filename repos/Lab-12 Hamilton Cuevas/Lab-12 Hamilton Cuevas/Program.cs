using System.Dynamic;

namespace Lab_12_Hamilton_Cuevas
{
    
    internal class Program
    {
        static int[,] matrizNumeros= new int[3,3];

        static int[,] matrizaleotorio;

       
        



        static void Actividad1()
        {
            Console.WriteLine("Programa Hecho por Hamilton Cuevas 1190526");
            Console.WriteLine("Actividad 1: arreglos bidimensionales");
            for (int contfilas = 0; contfilas < 3; contfilas++)
            {
                for (int contcolumnas = 0; contcolumnas < 3; contcolumnas++)
                {
                    Console.WriteLine($"Ingrese el numero para la fila {contfilas} y columna {contcolumnas}");
                    matrizNumeros[contfilas, contcolumnas] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

            }// Imprimir la matriz con foreach
            foreach (int item in matrizNumeros)
            {
                Console.WriteLine($"Valor: {item}");
            }
            Console.WriteLine();

            // Imprimir la matriz con for anidado
            for (int contfilas = 0; contfilas < 3; contfilas++)
            {
                for (int contcolumnas = 0; contcolumnas < 3; contcolumnas++)
                {
                    Console.Write($"{matrizNumeros[contfilas, contcolumnas]}\t");
                }
                Console.WriteLine();
            }


            // Calcular el producto de los elementos de la matriz 
            int producto = 1;
            foreach (int item in matrizNumeros)
            {
                producto *= item;
                Console.WriteLine($"Valor {producto}");
            }
        }

        static void Actividad2()
        {
            Console.WriteLine("Programa Hecho por Hamilton Cuevas 1190526");
            Console.WriteLine("Actividad 2: llenar arreglo bidimensionales con numeros aleatorios");
            Random random = new Random();
            int Nfilas, Ncolumnas, contadorPares=0, contadorImpares=0, Nmayor=0, Nmenor=100;

            Console.WriteLine("Ingrese el numero de filas para la matriz");
            Nfilas= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de columnas para la matriz");
            Ncolumnas=int.Parse(Console.ReadLine());

            matrizaleotorio = new int[Nfilas,Ncolumnas];
            Console.WriteLine();


            for (int filas = 0; filas < matrizaleotorio.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrizaleotorio.GetLength(1); columnas++)
                {
                    matrizaleotorio[filas, columnas] = random.Next(1,101);
                }
            }

            for (int filas = 0; filas < matrizaleotorio.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matrizaleotorio.GetLength(1); columnas++)
                {
                    Console.Write($"{matrizaleotorio[filas, columnas]}\t");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < matrizaleotorio.GetLength(0); i++)
            {
                for(int j = 0; j < matrizaleotorio.GetLength(1); j++)
                {
                    if (matrizaleotorio[i,j] % 2 == 0)
                    {
                        contadorPares++;
                    }
                    else
                    {
                        contadorImpares++;
                    }
                }
            }
            Console.WriteLine($"la cantidad de numeros pares es: {contadorPares}");
            Console.WriteLine($"la cantidad de numeros impares es: {contadorImpares}");
            Console.WriteLine();

            for (int i =0; i< matrizaleotorio.GetLength(0); i++)
            {
                for (int j = 0; j < matrizaleotorio.GetLength(1); j++)
                {
                    if (matrizaleotorio[i, j] > Nmayor)
                    {
                        Nmayor = matrizaleotorio[i, j];

                    }
                    else if (matrizaleotorio[i, j] < Nmenor)
                    {
                        Nmenor = matrizaleotorio[i, j];
                    }
                }
            }
            Console.WriteLine($"El numero mayor es: {Nmayor}");
            Console.WriteLine($"El numero menor es: {Nmenor}");

        }

        static void Main(string[] args)
        {
            Actividad2();
        }
    }
}
