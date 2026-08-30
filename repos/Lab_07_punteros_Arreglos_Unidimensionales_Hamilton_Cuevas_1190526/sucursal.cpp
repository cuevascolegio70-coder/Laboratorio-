#include "sucursal.h"
#include <iostream>
#include <string>

using namespace std;

Sucursal::Sucursal(string nombre, string direccion, double MontoVentas) {
    this->nombre = nombre;
    this->direccion = direccion;
    this->MontoVentas = MontoVentas;
}


void Sucursal::getinfo() const {
    cout << "Nombre: " << nombre << endl;
    cout << "Direccion: " << direccion << endl;
    cout << "Monto de Ventas: " << MontoVentas << endl;
}

string Sucursal::getNombre() const {
    return nombre;
}

string Sucursal::getDireccion() const {
    return direccion;
}

double Sucursal::getMontoVentas() const {
    return MontoVentas;
}