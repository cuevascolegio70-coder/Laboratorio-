#include "vivienda.h"
#include <iostream>

using namespace std;

int main() {
    const int MAX_VIVIENDAS = 5;
    Vivienda* viviendas[MAX_VIVIENDAS] = {nullptr, nullptr, nullptr, nullptr, nullptr};
    char opcion;

    do {
        cout << "\n======== MENU DE OPCIONES ========" << endl;
        cout << "a. Registrar Vivienda" << endl;
        cout << "b. Ver informacion de Vivienda" << endl;
        cout << "c. Salir" << endl;
        cout << "Seleccione una opcion: ";
        cin >> opcion;

        switch (tolower(opcion)) {
            case 'a': {
                int indiceLibre = -1;

                // Verificar si existe algún puntero sin asignar
                for (int i = 0; i < MAX_VIVIENDAS; i++) {
                    if (viviendas[i] == nullptr) {
                        indiceLibre = i;
                        break;
                    }
                }

                if (indiceLibre != -1) {
                    viviendas[indiceLibre] = crearVivienda();
                    cout << "\n[!] Vivienda registrada con exito en el espacio #" << (indiceLibre + 1) << "." << endl;
                } else {
                    cout << "\n[Error] Ya no existen espacios vacios disponibles para registrar mas viviendas." << endl;
                }
                break;
            }

            case 'b': {
                bool hayRegistros = false;

                // 1. Mostrar cuáles viviendas están registradas actualmente
                cout << "\n--- Viviendas Disponibles ---" << endl;
                for (int i = 0; i < MAX_VIVIENDAS; i++) {
                    if (viviendas[i] != nullptr) {
                        cout << (i + 1) << ". Vivienda del comprador: " << viviendas[i]->nombreComprador << endl;
                        hayRegistros = true;
                    }
                }

                // 2. Si hay al menos una vivienda, solicitar cuál desea consultar
                if (hayRegistros) {
                    int seleccion;
                    cout << "\nIngrese el numero de la vivienda que desea consultar (1-" << MAX_VIVIENDAS << "): ";
                    cin >> seleccion;

                    int indice = seleccion - 1;

                    // Validar la entrada del usuario y que la casilla no esté vacía
                    if (indice >= 0 && indice < MAX_VIVIENDAS && viviendas[indice] != nullptr) {
                        viviendas[indice]->mostrarInformacion();
                    } else {
                        cout << "\n[Error] La opcion ingresada no corresponde a una vivienda registrada." << endl;
                    }
                } else {
                    cout << "[!] No hay ninguna vivienda registrada todavia." << endl;
                }
                break;
            }

            case 'c': // Inciso 8: Finalizar programa
                cout << "\nSaliendo del programa y liberando memoria..." << endl;
                break;

            default:
                cout << "\n[!] Opcion invalida. Intente de nuevo." << endl;
                break;
        }

    } while (tolower(opcion) != 'c');

    // Liberación de la memoria dinámica utilizada
    for (int i = 0; i < MAX_VIVIENDAS; i++) {
        if (viviendas[i] != nullptr) {
            delete viviendas[i];
            viviendas[i] = nullptr;
        }
    }

    return 0;
}