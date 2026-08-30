using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Programa hecho por Hamilton Cuevas");


for (int j = 1; j <= 10; j++)//este ciclo lleva el control de las tablas
{
    Console.WriteLine($"Tabla del No. {j}");
    for (int i = 1; i <= 10; i++)//este ciclo lleva el control de las multiplicaciones
    {
        Console.WriteLine($"{j} * {i} = {j*i}");
    }
    Console.WriteLine("");//esto es para dejar un espacio entre cada tabla

}

Console.WriteLine("actividad No. 03");
Console.WriteLine("Programa hecho por Hamilton Cuevas");

int numero = 0;
int resultado= 1;


Console.WriteLine("Ingrese un numero para calcular su factorial: ");
numero=int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    resultado = resultado*i;
    
}
Console.WriteLine($"Resultado:{resultado}");