#ifndef SIMULADORMERCADO_H
#define SIMULADORMERCADO_H

#include "Jugador.h"
#include <vector>
#include <string>

using namespace std;

struct Club {
    int id;
    string nombre;
    int presupuesto;
    vector<Jugador*> plantilla;
};

struct Oferta {
    int id;
    Jugador* jugador;
    int compradorId;
    int vendedorId;
    int monto;
    string estado; // PENDIENTE, ACEPTADA, RECHAZADA
};

struct Transferencia {
    int dia;
    string jugadorNombre;
    string origenNombre;
    string destinoNombre;
    int monto;
};

class SimuladorMercado {
private:
    vector<Club> clubes;
    vector<Jugador*> todosLosJugadores;
    vector<Oferta> ofertas;
    vector<Transferencia> historial;
    int clubUsuarioId;
    int diasTotales;
    int diaActual;

    void inicializarClubesYJugadores();
    Club* buscarClubPorId(int id);
    const Club* buscarClubPorId(int id) const;
    string obtenerPosicionJugador(const Jugador* j) const;
    bool contarPosicion(const Club& club, const string& posicionTarget) const;
    bool validarTransferencia(const Oferta& oferta, string& razonRechazo);
    void ejecutarTransferencia(Oferta& oferta);
    void generarOfertaRival();
    void actualizarValoresMercado();

    void limpiarPantalla() const;
    void pausar() const;

public:
    SimuladorMercado();
    ~SimuladorMercado();

    void inicializarSimulacion();
    void verMiClub() const;
    void explorarJugadores() const;
    void realizarOferta();
    void revisarOfertasRecibidas();
    void verHistorial() const;
    void avanzarDia();
    void mostrarReporteFinal() const;
    void mostrarMenuPrincipal();
};

#endif // SIMULADORMERCADO_H