#include "pch.h"
#include "CarroElectrico.h"
#include "Camion.h"
#include <iostream>

using namespace System; 

int main(array<System::String ^> ^args)
{
	CarroElectrico tesla("Tesla", 2023, 45000, 75);
	Camion volvo("Volvo", 2019, 80000, 12000);

	Vehiculo* vehiculos[2] = { &tesla, &volvo };

	for (int i = 0; i < 2; i++) {
		std::cout << "Marca: " << vehiculos[i]->ObtenerMarca() << std::endl;
		std::cout << "Impuesto estandar: $" << vehiculos[i]->CalcularImpuesto() << std::endl;
		std::cout << std::endl;
	}

	std::cout << "Impuesto con recargo (Tesla, 3 anios adicionales): $" << tesla.CalcularImpuesto(3) << std::endl;
	std::cout << "Impuesto con recargo (Volvo, 0 anios adicionales): $" << volvo.CalcularImpuesto(0) << std::endl;

	return 0;
}
