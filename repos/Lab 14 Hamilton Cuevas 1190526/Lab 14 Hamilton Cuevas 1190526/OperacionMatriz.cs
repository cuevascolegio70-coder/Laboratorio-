using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14_Hamilton_Cuevas_1190526
{
    class OperacionesMatriz
    {
        public Estudiante[,] matriz = new Estudiante[2, 3];
        
        public OperacionesMatriz()
        {
        }
        public void IngresarDatosMatriz()
        {
            //se llena los datos de la matriz utilizando 2 ciclos for
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.WriteLine($"Ingrese el estudiante para la posicion [ { fila } ][ { columna } ]" ) ;
                    Console.WriteLine($"Ingrese el nombre estudiante ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Ingrese el carné estudiante ");
                    string carnet = Console.ReadLine();

                    Curso[] cursos = new Curso[2];
                    for (int i =0; i < cursos.Length; i++)
                    {
                        Console.WriteLine($"Ingrese el nombre del curso {i+1}: ");
                        string nombreCurso = Console.ReadLine();
                        Console.WriteLine($"Ingrese La nota final del curso {i+1}: ");
                        double notaFinal = double.Parse(Console.ReadLine());
                        Curso curso = new Curso (nombreCurso, notaFinal);
                        cursos[i] = curso;
                    }
                    Estudiante estudiante = new Estudiante(nombre, carnet, cursos);
                    matriz[fila, columna] = estudiante;
                }
                
            }
        }
       
        public void ConsultarEstudiante(int fila, int columna)
        {
            Console.WriteLine($"nombre: {matriz[fila, columna].nombre} ");
            Console.WriteLine($"carné: {matriz[fila, columna].carnet} ");
            Console.WriteLine($"Cursos:");
            for (int i = 0; i < matriz[fila, columna].cursos.Length; i++)
            {
                Console.WriteLine($"  Curso {i + 1}: {matriz[fila, columna].cursos[i].curso}, Nota: {matriz[fila, columna].cursos[i].notaFinal}");
            }
        }
    }
}
