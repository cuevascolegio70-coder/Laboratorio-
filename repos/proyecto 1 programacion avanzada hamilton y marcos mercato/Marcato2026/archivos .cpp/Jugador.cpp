#include "Jugador.h"
#include <iostream>

using namespace std;

Jugador::Jugador(int id, string nombre, int valorMercado, string clubActual)
    : id(id), nombre(nombre), valorMercado(valorMercado), clubActual(clubActual) {}

Jugador::~Jugador() {}

int Jugador::getId() const { return id; }
string Jugador::getNombre() const { return nombre; }
int Jugador::getValorMercado() const { return valorMercado; }
void Jugador::setValorMercado(int nuevoValor) { valorMercado = nuevoValor; }
string Jugador::getClubActual() const { return clubActual; }
void Jugador::setClubActual(const string& nuevoClub) { clubActual = nuevoClub; }

// Portero
Portero::Portero(int id, string nombre, int valorMercado, string clubActual)
    : Jugador(id, nombre, valorMercado, clubActual) {}

void Portero::mostrarDescripcion() const {
    cout << "[POR] ID: " << id << " | " << nombre 
         << " | Valor: EUR " << valorMercado << "M | Club: " << clubActual << "\n";
}

// Defensa
Defensa::Defensa(int id, string nombre, int valorMercado, string clubActual)
    : Jugador(id, nombre, valorMercado, clubActual) {}

void Defensa::mostrarDescripcion() const {
    cout << "[DEF] ID: " << id << " | " << nombre 
         << " | Valor: EUR " << valorMercado << "M | Club: " << clubActual << "\n";
}

// Mediocampista
Mediocampista::Mediocampista(int id, string nombre, int valorMercado, string clubActual)
    : Jugador(id, nombre, valorMercado, clubActual) {}

void Mediocampista::mostrarDescripcion() const {
    cout << "[MED] ID: " << id << " | " << nombre 
         << " | Valor: EUR " << valorMercado << "M | Club: " << clubActual << "\n";
}

// Delantero
Delantero::Delantero(int id, string nombre, int valorMercado, string clubActual)
    : Jugador(id, nombre, valorMercado, clubActual) {}

void Delantero::mostrarDescripcion() const {
    cout << "[DEL] ID: " << id << " | " << nombre 
         << " | Valor: EUR " << valorMercado << "M | Club: " << clubActual << "\n";
}