#ifndef CARRO_ELECTRICO_H
#define CARRO_ELECTRICO_H

#include "Vehiculo.h"

class CarroElectrico : public Vehiculo {
private:
	double bateriaKwH;

public:
	CarroElectrico(std::string marca, int anio, double costoBase, double bateriaKwH);
	using Vehiculo::CalcularImpuesto;
	double CalcularImpuesto() override;
};

#endif // !CARRO_ELECTRICO_H
