#ifndef ESTRUCTURAS_H
#define ESTRUCTURAS_H

#include <string>
#include <vector>
#include "Jugador.h"

struct Club {
    int id;
    std::string nombre;
    int presupuesto; // En millones de EUR
    std::vector<Jugador*> plantilla;
};

struct Oferta {
    int id;
    Jugador* jugador;
    int compradorId;
    int vendedorId;
    int monto;
    std::string estado; // "PENDIENTE", "ACEPTADA", "RECHAZADA"
};

struct Transferencia {
    int dia;
    std::string jugadorNombre;
    std::string origenNombre;
    std::string destinoNombre;
    int monto;
};

#endif // ESTRUCTURAS_H