#include "pch.h"
#include "Vehiculo.h"

Vehiculo::Vehiculo(std::string marca, int anio, double costoBase) {
	this->marca = marca;
	this->anio = anio;
	this->costoBase = costoBase;
}

std::string Vehiculo::ObtenerMarca() {
	return marca;
}

double Vehiculo::CalcularImpuesto(int aniosAdicionales) {
	double impuestoBase = CalcularImpuesto();
	double recargo = impuestoBase * 0.02 * aniosAdicionales;
	return impuestoBase + recargo;
}
