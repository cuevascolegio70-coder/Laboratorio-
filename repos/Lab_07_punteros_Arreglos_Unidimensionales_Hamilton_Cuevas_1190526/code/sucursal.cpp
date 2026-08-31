#include "Sucursal.h"
#include <sstream>

Sucursal::Sucursal(const std::string& nombre, const std::string& direccion, double montoVentas)
    : nombre(nombre), direccion(direccion), montoVentas(montoVentas) {}

Sucursal::~Sucursal() {}

void Sucursal::setNombre(const std::string& nombre) {
    this->nombre = nombre;
}

std::string Sucursal::getNombre() const {
    return nombre;
}

void Sucursal::setDireccion(const std::string& direccion) {
    this->direccion = direccion;
}

std::string Sucursal::getDireccion() const {
    return direccion;
}

void Sucursal::setMontoVentas(double montoVentas) {
    this->montoVentas = montoVentas;
}

double Sucursal::getMontoVentas() const {
    return montoVentas;
}

void Sucursal::acumularVentas(double monto) {
    if (monto > 0) {
        this->montoVentas += monto;
    }
}

std::string Sucursal::obtenerInformacion() const {
    std::ostringstream ss;
    ss << "Tipo: Sucursal Base\n"
       << "Nombre: " << nombre << "\n"
       << "Direccion: " << direccion << "\n"
       << "Monto de Ventas: Q" << montoVentas;
    return ss.str();
}