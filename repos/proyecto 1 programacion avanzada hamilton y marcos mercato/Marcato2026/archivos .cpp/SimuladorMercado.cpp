#include "SimuladorMercado.h"
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <algorithm>

using namespace std;

SimuladorMercado::SimuladorMercado() 
    : clubUsuarioId(-1), diasTotales(5), diaActual(1) {
    srand(static_cast<unsigned int>(time(nullptr)));
}

SimuladorMercado::~SimuladorMercado() {
    for (Jugador* j : todosLosJugadores) {
        delete j;
    }
    todosLosJugadores.clear();
}

void SimuladorMercado::limpiarPantalla() const {
#if defined(_WIN32) || defined(_WIN64)
    system("cls");
#else
    system("clear");
#endif
}

void SimuladorMercado::pausar() const {
    cout << "\nPresione Enter para continuar...";
    cin.ignore(10000, '\n');
    cin.get();
}

string SimuladorMercado::obtenerPosicionJugador(const Jugador* j) const {
    if (dynamic_cast<const Portero*>(j)) return "Portero";
    if (dynamic_cast<const Defensa*>(j)) return "Defensa";
    if (dynamic_cast<const Mediocampista*>(j)) return "Mediocampista";
    if (dynamic_cast<const Delantero*>(j)) return "Delantero";
    return "Desconocido";
}

bool SimuladorMercado::contarPosicion(const Club& club, const string& posicionTarget) const {
    int count = 0;
    for (const Jugador* j : club.plantilla) {
        if (obtenerPosicionJugador(j) == posicionTarget) {
            count++;
        }
    }
    return count > 1;
}

Club* SimuladorMercado::buscarClubPorId(int id) {
    for (auto& c : clubes) {
        if (c.id == id) return &c;
    }
    return nullptr;
}

const Club* SimuladorMercado::buscarClubPorId(int id) const {
    for (const auto& c : clubes) {
        if (c.id == id) return &c;
    }
    return nullptr;
}

void SimuladorMercado::inicializarClubesYJugadores() {
    vector<string> nombresClubes = {
        "Real Madrid", "FC Barcelona", "Manchester City", 
        "Liverpool", "Bayern Munich", "Paris Saint-Germain"
    };

    for (int i = 0; i < 6; ++i) {
        Club c;
        c.id = i + 1;
        c.nombre = nombresClubes[i];
        c.presupuesto = 100 + (rand() % 101);
        clubes.push_back(c);
    }

    auto crearJ = [&](int id, string nom, string pos, int minV, int maxV, int clubIdx) {
        int v = minV + (rand() % (maxV - minV + 1));
        string clubNom = clubes[clubIdx].nombre;
        Jugador* j = nullptr;
        if (pos == "POR") j = new Portero(id, nom, v, clubNom);
        else if (pos == "DEF") j = new Defensa(id, nom, v, clubNom);
        else if (pos == "MED") j = new Mediocampista(id, nom, v, clubNom);
        else if (pos == "DEL") j = new Delantero(id, nom, v, clubNom);

        todosLosJugadores.push_back(j);
        clubes[clubIdx].plantilla.push_back(j);
    };

    crearJ(1, "Thibaut Courtois", "POR", 20, 70, 0);
    crearJ(2, "Antonio Rudiger", "DEF", 25, 90, 0);
    crearJ(3, "Jude Bellingham", "MED", 30, 110, 0);
    crearJ(4, "Vinicius Junior", "DEL", 35, 140, 0);
    crearJ(5, "Kylian Mbappe", "DEL", 35, 140, 0);

    crearJ(6, "Marc-Andre ter Stegen", "POR", 20, 70, 1);
    crearJ(7, "Ronald Araujo", "DEF", 25, 90, 1);
    crearJ(8, "Pedri Gonzalez", "MED", 30, 110, 1);
    crearJ(9, "Lamine Yamal", "DEL", 35, 140, 1);
    crearJ(10, "Gavi", "MED", 30, 110, 1);

    crearJ(11, "Ederson Moraes", "POR", 20, 70, 2);
    crearJ(12, "Ruben Dias", "DEF", 25, 90, 2);
    crearJ(13, "Kevin De Bruyne", "MED", 30, 110, 2);
    crearJ(14, "Erling Haaland", "DEL", 35, 140, 2);
    crearJ(15, "Rodri Hernandez", "MED", 30, 110, 2);

    crearJ(16, "Alisson Becker", "POR", 20, 70, 3);
    crearJ(17, "Virgil van Dijk", "DEF", 25, 90, 3);
    crearJ(18, "Alexis Mac Allister", "MED", 30, 110, 3);
    crearJ(19, "Mohamed Salah", "DEL", 35, 140, 3);
    crearJ(20, "Cody Gakpo", "DEL", 35, 140, 3);

    crearJ(21, "Manuel Neuer", "POR", 20, 70, 4);
    crearJ(22, "Dayot Upamecano", "DEF", 25, 90, 4);
    crearJ(23, "Joshua Kimmich", "MED", 30, 110, 4);
    crearJ(24, "Harry Kane", "DEL", 35, 140, 4);
    crearJ(25, "Jamal Musiala", "MED", 30, 110, 4);

    crearJ(26, "Gianluigi Donnarumma", "POR", 20, 70, 5);
    crearJ(27, "Marquinhos", "DEF", 25, 90, 5);
    crearJ(28, "Vitinha", "MED", 30, 110, 5);
    crearJ(29, "Ousmane Dembele", "DEL", 35, 140, 5);
    crearJ(30, "Bradley Barcola", "DEL", 35, 140, 5);
}

void SimuladorMercado::inicializarSimulacion() {
    limpiarPantalla();
    inicializarClubesYJugadores();

    cout << "=====================================================\n";
    cout << "      SIMULADOR DE TRANSFERENCIAS: MERCATO 2026      \n";
    cout << "=====================================================\n\n";

    cout << "Seleccione su club:\n";
    for (const auto& c : clubes) {
        cout << c.id << ". " << c.nombre << " (Presupuesto Inicial: EUR " << c.presupuesto << "M)\n";
    }

    do {
        cout << "Ingrese ID del club (1-6): ";
        cin >> clubUsuarioId;
    } while (clubUsuarioId < 1 || clubUsuarioId > 6);

    do {
        cout << "Ingrese duracion de la ventana de transferencias en dias (5-15): ";
        cin >> diasTotales;
    } while (diasTotales < 5 || diasTotales > 15);

    cout << "\nBienvenido, Director Deportivo del " << buscarClubPorId(clubUsuarioId)->nombre << "!\n";
    pausar();
}

void SimuladorMercado::verMiClub() const {
    const Club* userClub = buscarClubPorId(clubUsuarioId);
    cout << "\n-----------------------------------------------------\n";
    cout << "CLUB: " << userClub->nombre << " | PRESUPUESTO: EUR " << userClub->presupuesto << "M\n";
    cout << "-----------------------------------------------------\n";
    cout << "PLANTILLA ACTUAL (" << userClub->plantilla.size() << " jugadores):\n";
    for (const Jugador* j : userClub->plantilla) {
        j->mostrarDescripcion();
    }
    cout << "-----------------------------------------------------\n";
}

void SimuladorMercado::explorarJugadores() const {
    cout << "\n=====================================================\n";
    cout << "         EXPLORAR JUGADORES DE OTROS CLUBES         \n";
    cout << "=====================================================\n";
    cout << "1. Consultar todos los jugadores\n";
    cout << "2. Filtrar por posicion (Portero, Defensa, Mediocampista, Delantero)\n";
    cout << "3. Buscar por identificador (ID)\n";
    cout << "Seleccione una opcion: ";

    int opcionBusqueda;
    cin >> opcionBusqueda;

    bool encontrado = false;

    if (opcionBusqueda == 1) {
        cout << "\n--- TODOS LOS JUGADORES DE OTROS CLUBES ---\n";
        for (const auto& club : clubes) {
            if (club.id == clubUsuarioId) continue;
            
            for (const Jugador* j : club.plantilla) {
                j->mostrarDescripcion();
                encontrado = true;
            }
        }
    } 
    else if (opcionBusqueda == 2) {
        cout << "\nSeleccione la posicion:\n";
        cout << "1. Portero\n2. Defensa\n3. Mediocampista\n4. Delantero\nOpcion: ";
        int posOp;
        cin >> posOp;

        string targetPos = "";
        if (posOp == 1) targetPos = "Portero";
        else if (posOp == 2) targetPos = "Defensa";
        else if (posOp == 3) targetPos = "Mediocampista";
        else if (posOp == 4) targetPos = "Delantero";

        cout << "\n--- RESULTADOS PARA POSICION: " << targetPos << " ---\n";
        for (const auto& club : clubes) {
            if (club.id == clubUsuarioId) continue;

            for (const Jugador* j : club.plantilla) {
                if (obtenerPosicionJugador(j) == targetPos) {
                    j->mostrarDescripcion();
                    encontrado = true;
                }
            }
        }
    } 
    else if (opcionBusqueda == 3) {
        int idBuscar;
        cout << "\nIngrese el ID del jugador: ";
        cin >> idBuscar;

        cout << "\n--- RESULTADO DE BUSQUEDA POR ID (" << idBuscar << ") ---\n";
        for (const auto& club : clubes) {
            if (club.id == clubUsuarioId) continue;

            for (const Jugador* j : club.plantilla) {
                if (j->getId() == idBuscar) {
                    j->mostrarDescripcion();
                    encontrado = true;
                    break;
                }
            }
        }
    } 
    else {
        cout << "Opcion de busqueda invalida.\n";
        return;
    }

    if (!encontrado) {
        cout << "\n[RESULTADO]: No se encontraron jugadores que coincidan con la busqueda.\n";
    }
}

bool SimuladorMercado::validarTransferencia(const Oferta& oferta, string& razonRechazo) {
    Club* comprador = buscarClubPorId(oferta.compradorId);
    Club* vendedor = buscarClubPorId(oferta.vendedorId);

    if (!comprador || !vendedor || !oferta.jugador) {
        razonRechazo = "Datos de oferta invalidos.";
        return false;
    }

    if (comprador->id == vendedor->id) {
        razonRechazo = "No se puede comprar un jugador de tu propio club.";
        return false;
    }

    if (comprador->presupuesto < oferta.monto) {
        razonRechazo = "Presupuesto insuficiente (EUR " + to_string(comprador->presupuesto) + "M disponibles).";
        return false;
    }

    string pos = obtenerPosicionJugador(oferta.jugador);
    if (!contarPosicion(*vendedor, pos)) {
        razonRechazo = "El club vendedor no puede quedar sin jugadores en la posicion (" + pos + ").";
        return false;
    }

    return true;
}

void SimuladorMercado::ejecutarTransferencia(Oferta& oferta) {
    Club* comprador = buscarClubPorId(oferta.compradorId);
    Club* vendedor = buscarClubPorId(oferta.vendedorId);
    Jugador* j = oferta.jugador;

    comprador->presupuesto -= oferta.monto;
    vendedor->presupuesto += oferta.monto;

    auto it = find(vendedor->plantilla.begin(), vendedor->plantilla.end(), j);
    if (it != vendedor->plantilla.end()) {
        vendedor->plantilla.erase(it);
    }
    comprador->plantilla.push_back(j);
    j->setClubActual(comprador->nombre);

    oferta.estado = "ACEPTADA";
    Transferencia t;
    t.dia = diaActual;
    t.jugadorNombre = j->getNombre();
    t.origenNombre = vendedor->nombre;
    t.destinoNombre = comprador->nombre;
    t.monto = oferta.monto;
    historial.push_back(t);

    cout << "\n[TRANSFERENCIA COMPLETADA!] " << j->getNombre() 
         << " de " << vendedor->nombre 
         << " a " << comprador->nombre << " por EUR " << oferta.monto << "M.\n";
}

void SimuladorMercado::realizarOferta() {
    explorarJugadores();
    int jId;
    cout << "\nIngrese el ID del jugador que desea comprar: ";
    cin >> jId;

    Jugador* objetivo = nullptr;
    for (Jugador* j : todosLosJugadores) {
        if (j->getId() == jId) {
            objetivo = j;
            break;
        }
    }

    if (!objetivo) {
        cout << "\n[ERROR]: Jugador no encontrado.\n";
        return;
    }

    Club* miClub = buscarClubPorId(clubUsuarioId);
    if (objetivo->getClubActual() == miClub->nombre) {
        cout << "\n[ERROR]: Este jugador ya pertenece a tu club.\n";
        return;
    }

    Club* vendedor = nullptr;
    for (auto& c : clubes) {
        if (c.nombre == objetivo->getClubActual()) {
            vendedor = &c;
            break;
        }
    }

    int montoOferta;
    cout << "Valor actual de mercado: EUR " << objetivo->getValorMercado() << "M\n";
    cout << "Ingrese su oferta en millones de EUR: ";
    cin >> montoOferta;

    Oferta of;
    of.id = static_cast<int>(ofertas.size()) + 1;
    of.jugador = objetivo;
    of.compradorId = miClub->id;
    of.vendedorId = vendedor->id;
    of.monto = montoOferta;
    of.estado = "PENDIENTE";

    string razon;
    if (!validarTransferencia(of, razon)) {
        of.estado = "RECHAZADA";
        ofertas.push_back(of);
        cout << "\n[OFERTA RECHAZADA AUTOMATICAMENTE]: " << razon << "\n";
        return;
    }

    int minimoAceptable = static_cast<int>(objetivo->getValorMercado() * 1.10);
    if (montoOferta >= minimoAceptable) {
        ejecutarTransferencia(of);
    } else {
        of.estado = "RECHAZADA";
        cout << "\n[OFERTA RECHAZADA POR EL CLUB VENDEDOR]: El club exige al menos EUR " 
             << minimoAceptable << "M (110% del valor de mercado).\n";
    }
    ofertas.push_back(of);
}

void SimuladorMercado::generarOfertaRival() {
    Club* miClub = buscarClubPorId(clubUsuarioId);
    if (miClub->plantilla.empty()) return;

    Jugador* j = miClub->plantilla[rand() % miClub->plantilla.size()];
    
    int compradorIdx;
    do {
        compradorIdx = rand() % clubes.size();
    } while (clubes[compradorIdx].id == clubUsuarioId);

    Club& comprador = clubes[compradorIdx];

    double factor = 0.90 + (rand() % 41) / 100.0;
    int monto = static_cast<int>(j->getValorMercado() * factor);

    Oferta of;
    of.id = static_cast<int>(ofertas.size()) + 1;
    of.jugador = j;
    of.compradorId = comprador.id;
    of.vendedorId = miClub->id;
    of.monto = monto;
    of.estado = "PENDIENTE";

    ofertas.push_back(of);

    cout << "\n[NUEVA OFERTA RECIBIDA - DIA " << diaActual << "]\n";
    cout << comprador.nombre << " ha realizado una oferta de EUR " << monto 
         << "M por tu jugador " << j->getNombre() << " (Valor: EUR " << j->getValorMercado() << "M).\n";
}

void SimuladorMercado::revisarOfertasRecibidas() {
    vector<int> pendientesIdx;
    for (size_t i = 0; i < ofertas.size(); ++i) {
        if (ofertas[i].vendedorId == clubUsuarioId && ofertas[i].estado == "PENDIENTE") {
            pendientesIdx.push_back(static_cast<int>(i));
        }
    }

    if (pendientesIdx.empty()) {
        cout << "\nNo tienes ofertas recibidas pendientes.\n";
        return;
    }

    for (int idx : pendientesIdx) {
        Oferta& of = ofertas[idx];
        Club* comprador = buscarClubPorId(of.compradorId);
        cout << "\nOferta ID: " << of.id << " | Comprador: " << comprador->nombre 
             << " | Jugador: " << of.jugador->getNombre() 
             << " | Monto: EUR " << of.monto << "M\n";

        char op;
        cout << "Aceptar oferta? (s/n): ";
        cin >> op;

        if (op == 's' || op == 'S') {
            string razon;
            if (validarTransferencia(of, razon)) {
                ejecutarTransferencia(of);
            } else {
                of.estado = "RECHAZADA";
                cout << "[NO SE PUDO COMPLETAR]: " << razon << "\n";
            }
        } else {
            of.estado = "RECHAZADA";
            cout << "Oferta rechazada.\n";
        }
    }
}

void SimuladorMercado::verHistorial() const {
    cout << "\n=====================================================\n";
    cout << "            HISTORIAL DE TRANSFERENCIAS              \n";
    cout << "=====================================================\n";
    if (historial.empty()) {
        cout << "No se han realizado transferencias hasta el momento.\n";
    } else {
        for (const auto& t : historial) {
            cout << "Dia " << t.dia << " | " << t.jugadorNombre 
                 << " (" << t.origenNombre << " -> " << t.destinoNombre 
                 << ") | Monto: EUR " << t.monto << "M\n";
        }
    }
    cout << "=====================================================\n";
}

void SimuladorMercado::actualizarValoresMercado() {
    for (Jugador* j : todosLosJugadores) {
        int actual = j->getValorMercado();
        int cambioPct = (rand() % 11) - 5; 
        int nuevo = actual + static_cast<int>(actual * (cambioPct / 100.0));
        if (nuevo < 5) nuevo = 5;
        j->setValorMercado(nuevo);
    }
    cout << "\n[MERCADO]: Los valores de mercado de los jugadores han fluctuado (-5% a +5%).\n";
}

void SimuladorMercado::avanzarDia() {
    cout << "\n>>> Avanzando del Dia " << diaActual << " al Dia " << (diaActual + 1) << "... <<<\n";
    actualizarValoresMercado();
    generarOfertaRival();
    diaActual++;
}

void SimuladorMercado::mostrarReporteFinal() const {
    limpiarPantalla();
    cout << "=====================================================\n";
    cout << "          REPORTE FINAL DE LA SIMULACION             \n";
    cout << "=====================================================\n";

    for (const auto& club : clubes) {
        cout << "\nClub: " << club.nombre << " | Presupuesto Final: EUR " << club.presupuesto << "M\n";
        cout << "Plantilla Final (" << club.plantilla.size() << " jugadores):\n";
        for (const Jugador* j : club.plantilla) {
            cout << " - " << j->getNombre() << " (" << obtenerPosicionJugador(j) << ") - EUR " << j->getValorMercado() << "M\n";
        }
    }

    verHistorial();
    cout << "=====================================================\n";
    cout << "        FIN DE LA SIMULACION - MERCATO 2026          \n";
    cout << "=====================================================\n";
}

void SimuladorMercado::mostrarMenuPrincipal() {
    inicializarSimulacion();

    while (diaActual <= diasTotales) {
        limpiarPantalla();
        cout << "=== DIA " << diaActual << " DE " << diasTotales << " ===\n";
        cout << "1. Ver mi club\n";
        cout << "2. Explorar jugadores del mercado\n";
        cout << "3. Realizar una oferta de compra\n";
        cout << "4. Revisar ofertas recibidas\n";
        cout << "5. Ver historial de transferencias\n";
        cout << "6. Avanzar de dia\n";
        cout << "Seleccione una opcion: ";

        int op;
        cin >> op;

        limpiarPantalla();
        switch (op) {
            case 1: verMiClub(); break;
            case 2: explorarJugadores(); break;
            case 3: realizarOferta(); break;
            case 4: revisarOfertasRecibidas(); break;
            case 5: verHistorial(); break;
            case 6: avanzarDia(); break;
            default: cout << "Opcion invalida.\n"; break;
        }

        pausar();
    }

    mostrarReporteFinal();
}