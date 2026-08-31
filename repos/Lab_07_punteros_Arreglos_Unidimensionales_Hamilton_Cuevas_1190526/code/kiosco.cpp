#include "Kiosco.h"
#include <sstream>

Kiosco::Kiosco(const std::string& nombre, const std::string& direccion, double montoVentas, double renta)
    : Sucursal(nombre, direccion, montoVentas), renta(renta) {}

void Kiosco::setRenta(double renta) {
    this->renta = renta;
}

double Kiosco::getRenta() const {
    return renta;
}

std::string Kiosco::obtenerInformacion() const {
    std::ostringstream ss;
    ss << "--- TIPO: KIOSCO ---\n"
       << "Nombre: " << nombre << "\n"
       << "Direccion: " << direccion << "\n"
       << "Monto de Ventas: Q" << montoVentas << "\n"
       << "Renta Mensual: Q" << renta;
    return ss.str();
}