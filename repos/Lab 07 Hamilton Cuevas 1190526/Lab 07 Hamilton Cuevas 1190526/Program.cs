//Impriir menù de opccioones



int opcion = 1;

while (opcion!= 4)
{
    Console.WriteLine("Menú de opciones: \n 1.secuencia \n 2.nomina \n 3.promedio \n 4.salir \n Ingrese su opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
        {
            Console.WriteLine("ingrese el valor final de la secuencia: ");
            int valorFinal = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= valorFinal)
            {
                Console.WriteLine(contador);
                contador++;
            }
        }
            break;
        
        case 2:
        {  
            Console.WriteLine("Nomina"); 
            string respuesta = "s";
            float totalNomina = 0;
            float sueldoEmpleado = 0;
               while (respuesta == "s" || respuesta == "S")
                {
                    Console.WriteLine("ingrese el sueldo del empleado: ");
                    sueldoEmpleado = float.Parse(Console.ReadLine());
                    totalNomina += sueldoEmpleado;
                    Console.WriteLine("Desea Ingresar otro sueldo? (s/n): ");
                    respuesta = Console.ReadLine();
                    Console.WriteLine($"El total a desembolsar en la nomina es: {totalNomina} " );
                }
             break;
       
        }
        case 3:
        {
            int estudiantes;
            int contadorEstudiantes = 1;
            float notaEstudiantes;
            float sumaNotas = 0;
            float promedio= 0;

            Console.WriteLine("Ingrese el numero de estudiantes: ");
            estudiantes = int.Parse(Console.ReadLine());

            while (contadorEstudiantes <= estudiantes)
            {
                Console.WriteLine("ingrese la nota del estudiante:");
                notaEstudiantes = float.Parse(Console.ReadLine());
                contadorEstudiantes++;
                sumaNotas += notaEstudiantes;
                promedio =sumaNotas / estudiantes;
            }
                
                Console.WriteLine($"El promedio de la calse con {estudiantes} estudiantes fué de {promedio}");
        } 
            break;
        case 4:
            {
                   Console.WriteLine("Saliendo del programa...\n Gracias por usar el programa");
            }
            break;
    }
}
