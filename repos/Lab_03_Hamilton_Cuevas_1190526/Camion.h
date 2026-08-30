#ifndef CAMION_H
#define CAMION_H

#include "Vehiculo.h"

class Camion : public Vehiculo {
private:
	double cargaMaxima;

public:
	Camion(std::string marca, int anio, double costoBase, double cargaMaxima);
	using Vehiculo::CalcularImpuesto;
	double CalcularImpuesto() override;
};

#endif // !CAMION_H
