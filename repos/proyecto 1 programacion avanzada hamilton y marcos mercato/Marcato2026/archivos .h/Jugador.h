#ifndef JUGADOR_H
#define JUGADOR_H

#include <string>
#include <iostream>

using namespace std;

class Jugador {
protected:
    int id;
    string nombre;
    int valorMercado; // En millones de EUR
    string clubActual;

public:
    Jugador(int id, string nombre, int valorMercado, string clubActual);
    virtual ~Jugador();

    virtual void mostrarDescripcion() const = 0;

    int getId() const;
    string getNombre() const;
    int getValorMercado() const;
    void setValorMercado(int nuevoValor);
    string getClubActual() const;
    void setClubActual(const string& nuevoClub);
};

class Portero : public Jugador {
public:
    Portero(int id, string nombre, int valorMercado, string clubActual);
    void mostrarDescripcion() const override;
};

class Defensa : public Jugador {
public:
    Defensa(int id, string nombre, int valorMercado, string clubActual);
    void mostrarDescripcion() const override;
};

class Mediocampista : public Jugador {
public:
    Mediocampista(int id, string nombre, int valorMercado, string clubActual);
    void mostrarDescripcion() const override;
};

class Delantero : public Jugador {
public:
    Delantero(int id, string nombre, int valorMercado, string clubActual);
    void mostrarDescripcion() const override;
};

#endif // JUGADOR_H