#include "vivienda.h"

Vivienda::Vivienda(string nombreComprador, int numHabitaciones, int niveles, bool terraza, bool jardin, bool apartamento, int precio)
    : nombreComprador(nombreComprador), numHabitaciones(numHabitaciones), niveles(niveles), 
      terraza(terraza), jardin(jardin), apartamento(apartamento), precio(precio) {}

void Vivienda::mostrarInformacion() const {
    cout << "\n----------------------------------------" << endl;
    cout << "Comprador: " << nombreComprador << endl;
    cout << "Habitaciones: " << numHabitaciones << endl;
    cout << "Niveles: " << niveles << endl;
    cout << "Terraza: " << (terraza ? "Si" : "No") << endl;
    cout << "Jardin: " << (jardin ? "Si" : "No") << endl;
    cout << "Apartamento: " << (apartamento ? "Si" : "No") << endl;
    cout << "Precio: $" << precio << endl;
    cout << "----------------------------------------" << endl;
}

Vivienda* crearVivienda() {
    string nombreComprador;
    int numHabitaciones, niveles, precio;
    bool terraza, jardin, apartamento;

    cout << "\n--- Registrar Nueva Vivienda ---" << endl;
    cout << "Ingrese el nombre del comprador: ";
    getline(cin >> ws, nombreComprador);

    cout << "Ingrese el numero de habitaciones: ";
    cin >> numHabitaciones;

    cout << "Ingrese el numero de niveles: ";
    cin >> niveles;

    cout << "Ingrese si tiene terraza (1 para si, 0 para no): ";
    cin >> terraza;

    cout << "Ingrese si tiene jardin (1 para si, 0 para no): ";
    cin >> jardin;

    cout << "Ingrese si es apartamento (1 para si, 0 para no): ";
    cin >> apartamento;

    cout << "Ingrese el precio: ";
    cin >> precio;

    return new Vivienda(nombreComprador, numHabitaciones, niveles, terraza, jardin, apartamento, precio);
}