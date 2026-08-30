#include "pch.h"
#include "Camion.h"

Camion::Camion(std::string marca, int anio, double costoBase, double cargaMaxima)
	: Vehiculo(marca, anio, costoBase) {
	this->cargaMaxima = cargaMaxima;
}

double Camion::CalcularImpuesto() {
	return (costoBase * 0.15) + (cargaMaxima / 1000) * 50;
}
