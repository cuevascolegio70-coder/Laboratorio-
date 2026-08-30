5#include "pch.h"
#include "CarroElectrico.h"

CarroElectrico::CarroElectrico(std::string marca, int anio, double costoBase, double bateriaKwH)
	: Vehiculo(marca, anio, costoBase) {
	this->bateriaKwH = bateriaKwH;
}

double CarroElectrico::CalcularImpuesto() {
	return costoBase * 0.05;
}
