#ifndef VEHICULO_H
#define VEHICULO_H

#include <string>

class Vehiculo {
protected:
	std::string marca;
	int anio;
	double costoBase;

public:
	Vehiculo(std::string marca, int anio, double costoBase);
	std::string ObtenerMarca();
	virtual double CalcularImpuesto() = 0;
	double CalcularImpuesto(int aniosAdicionales);
	virtual ~Vehiculo() {}
};

#endif // !VEHICULO_H
