#include "pch.h"
#include <iostream>
#include <string>
#include "Clinica.h"
#include "Mascota.h"

using namespace std;
using namespace System;

int main()
{
	Clinica clinica;

	cout << "Ingrese la cantidad de turnos para consulta general: ";
	cin >> clinica.turnoConsultaGeneral;

	cout << "Ingrese la cantidad de turnos para emergencia: ";
	cin >> clinica.turnoEmergencia;
	cin.ignore();

	int opcion;

	do {
		cout << "\n---Menu de opciones---" << endl;
		cout << "1. Registrar ingreso de mascota" << endl;
		cout << "2. Registrar salida de mascota" << endl;
		cout << "3. Salir" << endl;
		cout << "Opcion: ";
		cin >> opcion;
		cin.ignore();

		switch (opcion) {
		case 1:
			clinica.registrarIngresoMascota();
			break;

		case 2:
			clinica.registrarSalidaMascota();
			break;

		case 3:
			cout << "Saliendo del programa..." << endl;
			break;

		default:
			cout << "Opcion invalida. Intente nuevamente." << endl;
			break;
		}

	} while (opcion != 3);
}