#ifndef VIVIENDA_H
#define VIVIENDA_H

#include <iostream>
#include <string>

using namespace std;

class Vivienda {
public:
    string nombreComprador;
    int numHabitaciones;
    int niveles;
    bool terraza; 
    bool jardin;
    bool apartamento;
    int precio;

    Vivienda(string nombreComprador, int numHabitaciones, int niveles, bool terraza, bool jardin, bool apartamento, int precio);
    
    // Método para imprimir la información
    void mostrarInformacion() const;
};

Vivienda* crearVivienda();

#endif