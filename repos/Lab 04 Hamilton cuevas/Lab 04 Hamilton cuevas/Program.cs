using System;

Console.WriteLine("Ejercicio 2: Converciones");
Console.WriteLine("Hecho por Hamilton Cuevas 1190526);");

double kilomoetros, millas, pies, pulgadas, metros;

Console.WriteLine("Ingrese una contidad de metros: ");
metros = int.Parse(Console.ReadLine());

kilomoetros = metros / 1000;
millas = metros / 1609.34;
pies = metros * 3.28084;
pulgadas = pies * 12;

Console.WriteLine($"{metros} a kilometros = {kilomoetros}");
Console.WriteLine($"{metros} a millas = {millas}");
Console.WriteLine($"{metros} a pies = {pies}");
Console.WriteLine($"{metros} a pulgadas = {pulgadas}");


























// Actividad 1 Operaciones Aritmeticas
// El WriteLIne es para que la consola escriba algo


Console.WriteLine("Actividad 1: Operacioones aritmeticas ");
Console.WriteLine("Hecho por Hamilton Cuevas 1190526);");
// Declaracion de variables
int num1, num2, suma, resta, multiplicacion, divisionEntera, divisionModular;
float divisionReal;

Console.WriteLine("Ingrese el primer numero: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
num2 = int.Parse(Console.ReadLine());


resta = num1 - num2;
suma = num1 + num2;
multiplicacion = num1 * num2;
divisionEntera = num1 / num2;
divisionReal = (float)num1 / num2;
divisionModular = num1 % num2;

Console.WriteLine($"{num1} + {num2} = {suma}");
Console.WriteLine($"{num1} - {num2} = {resta}");
Console.WriteLine($"{num1} * {num2} = {multiplicacion}");
Console.WriteLine($"{num1} / {num2} = {divisionEntera}");
Console.WriteLine($"{num1} / {num2} = {divisionReal}");
Console.WriteLine($"{num1} % {num2} = {divisionModular}");