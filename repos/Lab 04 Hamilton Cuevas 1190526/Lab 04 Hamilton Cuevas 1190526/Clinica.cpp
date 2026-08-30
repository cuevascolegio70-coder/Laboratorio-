#include "pch.h"
#include "Clinica.h"
#include "Mascota.h"
#include <iostream>
#include <string>

using namespace std;

void Clinica::registrarIngresoMascota() {
	string nombre, especie, nombreDueno;
	int tipoConsulta;

	cout << "Ingrese el nombre de la mascota: ";
	getline(cin, nombre);

	cout << "Ingrese la especie: ";
	getline(cin, especie);

	cout << "Ingrese el nombre del dueno: ";
	getline(cin, nombreDueno);

	cout << "Tipo de consulta (1. General, 2. Emergencia): ";
	cin >> tipoConsulta;
	cin.ignore();

	if (tipoConsulta == 1) {
		if (turnoConsultaGeneral <= 0) {
			cout << "No hay turnos disponibles para consulta general." << endl;
			return;
		}
		turnoConsultaGeneral--;
		mascotaActual = new Mascota(nombre, especie, nombreDueno, precioGeneral);
	}
	else if (tipoConsulta == 2) {
		if (turnoEmergencia <= 0) {
			cout << "No hay turnos disponibles para emergencia." << endl;
			return;
		}
		turnoEmergencia--;
		mascotaActual = new Mascota(nombre, especie, nombreDueno, precioEmergencia);
	}
	else {
		cout << "Tipo de consulta invalido." << endl;
		return;
	}

	cout << "Mascota registrada con exito." << endl;
	cout << "Hora de ingreso: " << mascotaActual->formatearHora(mascotaActual->horaIngreso) << endl;
}

void Clinica::registrarSalidaMascota() {
	if (mascotaActual == nullptr) {
		cout << "No hay ninguna mascota registrada actualmente." << endl;
		return;
	}

	string nombre;
	cout << "Ingrese el nombre de la mascota que sale: ";
	getline(cin, nombre);

	if (nombre != mascotaActual->nombre) {
		cout << "El nombre no coincide con la mascota registrada." << endl;
		return;
	}

	mascotaActual->setHoraSalida();

	cout << "Hora de ingreso: " << mascotaActual->formatearHora(mascotaActual->horaIngreso) << endl;
	cout << "Hora de salida: " << mascotaActual->formatearHora(mascotaActual->horaSalida) << endl;
	cout << "Se debe cobrar: $" << mascotaActual->cobro() << endl;

	if (mascotaActual->precioConsulta == precioGeneral) {
		turnoConsultaGeneral++;
	}
	else {
		turnoEmergencia++;
	}

	delete mascotaActual;
	mascotaActual = nullptr;
}