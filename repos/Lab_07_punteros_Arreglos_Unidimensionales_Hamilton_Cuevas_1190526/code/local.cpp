#include "Local.h"
#include <sstream>

Local::Local(const std::string& nombre, const std::string& direccion, double montoVentas, double fondo, double ancho)
    : Sucursal(nombre, direccion, montoVentas), fondo(fondo), ancho(ancho) {}

void Local::setFondo(double fondo) {
    this->fondo = fondo;
}

double Local::getFondo() const {
    return fondo;
}

void Local::setAncho(double ancho) {
    this->ancho = ancho;
}

double Local::getAncho() const {
    return ancho;
}

std::string Local::obtenerInformacion() const {
    std::ostringstream ss;
    ss << "--- TIPO: LOCAL ---\n"
       << "Nombre: " << nombre << "\n"
       << "Direccion: " << direccion << "\n"
       << "Monto de Ventas: Q" << montoVentas << "\n"
       << "Fondo: " << fondo << " m\n"
       << "Ancho: " << ancho << " m";
    return ss.str();
}