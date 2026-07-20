#include "pch.h"
#include "iostream"
using namespace System;
int main(array <System::String^>^ args)
{
	double num1, num2;
	double division;
	Console::WriteLine("Ingrese el primer número:");
	String^ input1 = Console::ReadLine();
	num1 = Convert::ToDouble(input1);
	Console::WriteLine("Ingrese el segundo número:");
	String^ input2 = Console::ReadLine();
	num2 = Convert::ToDouble(input2);
	division = num1 / num2;

	double suma = num1 + num2;
	double raiz = Math::Sqrt(num1);
	double potencia = Math::Pow(num2, 3);

	//Diferentes formas de imprimir una variable
	Console::WriteLine("División: " + division + " Suma: " + suma + " Raíz: " + raiz + " Potencia: " + potencia);
	//Console::WriteLine("División: {0}", division);
	return 0;
}

