Console.WriteLine("Hecho por: Hamilton Cuevas " + "Carne: 1190526");

float notaEstudiante;

Console.WriteLine("ingrese la nota del estudiante");

notaEstudiante= int.Parse(Console.ReadLine());

if (notaEstudiante >= 0 && notaEstudiante <= 100)
{
    {
     
    }
    if (notaEstudiante >= 65)
    {
        Console.WriteLine("aprobado");

    }
    else
    {

        Console.WriteLine("No aprobado");
    }
}

else
{
   Console.WriteLine("Nota no valida");
}



float montoFactura;

Console.WriteLine("ingrese el monto de la factura: ");

montoFactura = float.Parse(Console.ReadLine());

if (montoFactura > 2000)
{
    Console.WriteLine("Ganó la membresia");
}
else
{
    if (montoFactura > 500)
    {
        Console.WriteLine("Ganó el número de rifa");
    }
    else
    { 
        if (montoFactura > 200)
         {
            Console.WriteLine("Ganó el cupon de descuento");
         }
        else
        {
            Console.WriteLine("no ganó nada");
        }    
     }
}

//forma 2


Console.WriteLine("ingrese el monto de la factura: ");

montoFactura = float.Parse(Console.ReadLine());

if (montoFactura >= 200 && montoFactura < 500)
{
    Console.WriteLine("Ganó el cupon de descuento");
}
else if (montoFactura >= 500 && montoFactura < 2000)
{
    Console.WriteLine("Ganó el número de rifa");
}
else if (montoFactura > 2000)
{
    Console.WriteLine("Ganó la membresia");
}
else
{
    Console.WriteLine("no ganó nada");
}


int numeroMaya, divisionModular, divisionReal;

Console.WriteLine("Ingrese un numero del 1 al 19: ");

numeroMaya = int.Parse(Console.ReadLine());

if (numeroMaya >=0 && numeroMaya <= 19)
{
    divisionModular =  numeroMaya / 5;
    divisionReal =  numeroMaya % 5;
    Console.WriteLine($"el nuemero de Lineas del numero maya es:{divisionModular} ");

    Console.WriteLine($"el numero de puntos del numero maya es: {divisionReal}");

}
else
{
    Console.WriteLine("Numero invalido");

}