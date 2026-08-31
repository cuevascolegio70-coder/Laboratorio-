#include <iostream>
#include <limits>
#include "Sucursal.h"
#include "Local.h"
#include "Kiosco.h"

using namespace std;

int main() {
    int cantidad = 0;

    cout << "==========================================\n";
    cout << "     SISTEMA DE GESTION DE SUCURSALES     \n";
    cout << "==========================================\n";
    cout << "Ingrese la cantidad de sucursales a registrar: ";
    cin >> cantidad;

    while (cantidad <= 0) {
        cout << "Por favor ingrese un numero mayor a 0: ";
        cin >> cantidad;
    }

    // Arreglo dinámico que guarda punteros a Sucursal
    Sucursal** sucursales = new Sucursal*[cantidad];

    for (int i = 0; i < cantidad; ++i) {
        int opcion = 0;
        cout << "\n------------------------------------------\n";
        cout << "Registro de la Sucursal #" << (i + 1) << endl;
        cout << "Seleccione el tipo de establecimiento:\n";
        cout << "1. Local\n";
        cout << "2. Kiosco\n";
        cout << "Opcion: ";
        cin >> opcion;

        while (opcion != 1 && opcion != 2) {
            cout << "Opcion invalida. Ingrese 1 para Local o 2 para Kiosco: ";
            cin >> opcion;
        }

        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        string nombre, direccion;
        double ventas = 0.0;

        cout << "Nombre de la sucursal: ";
        getline(cin, nombre);

        cout << "Direccion: ";
        getline(cin, direccion);

        cout << "Monto inicial de ventas: Q";
        cin >> ventas;

        if (opcion == 1) {
            double fondo = 0.0, ancho = 0.0;
            cout << "Medida del fondo (metros): ";
            cin >> fondo;
            cout << "Medida del ancho (metros): ";
            cin >> ancho;

            sucursales[i] = new Local(nombre, direccion, ventas, fondo, ancho);
        } else {
            double renta = 0.0;
            cout << "Monto de la renta mensual: Q";
            cin >> renta;

            sucursales[i] = new Kiosco(nombre, direccion, ventas, renta);
        }
    }

    // Impresión con polimorfismo
    cout << "\n==========================================\n";
    cout << "   LISTADO DE SUCURSALES REGISTRADAS      \n";
    cout << "==========================================\n";

    for (int i = 0; i < cantidad; ++i) {
        cout << "\n[Sucursal #" << (i + 1) << "]\n";
        // Llamada polimórfica utilizando el puntero
        cout << sucursales[i]->obtenerInformacion() << endl;
    }

    // Liberación de memoria dinámica
    for (int i = 0; i < cantidad; ++i) {
        delete sucursales[i];
    }
    delete[] sucursales;
    sucursales = nullptr;

    cout << "\nMemoria liberada correctamente. Fin del programa.\n";

    return 0;
}