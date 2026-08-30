#ifndef CLINICA_H
#define CLINICA_H

#include <string>
#include "Mascota.h"

using namespace std;

struct Clinica {
	int turnoConsultaGeneral;
	int turnoEmergencia;
	double precioGeneral;
	double precioEmergencia;

	Mascota* mascotaActual;

	Clinica() {
		turnoConsultaGeneral = 0;
		turnoEmergencia = 0;
		precioGeneral = 500;
		precioEmergencia = 1000;
		mascotaActual = nullptr;
	}

public:

	void registrarIngresoMascota();
	void registrarSalidaMascota();
};

#endif // !CLINICA_H