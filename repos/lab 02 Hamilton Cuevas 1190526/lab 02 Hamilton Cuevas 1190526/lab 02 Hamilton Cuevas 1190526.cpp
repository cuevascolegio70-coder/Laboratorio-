#include "pch.h"
#include "mascota.h"
#include <iostream>

int main() {
	Mascota miMascota("Perro", "Firulais", "12/5/2020", 0, false, "Juan Perez", "5555-1234");

	miMascota.obtenerEspecie();
	miMascota.obtenerNombre();
	miMascota.obtenerFechaNacimiento();
	miMascota.obtenernombreDueño();
	miMascota.obtenerTelefono();

	std::cout << "\n--- Antes de tener citas ---" << std::endl;
	miMascota.obtenerFechaUltimaVisita();
	miMascota.verificarProximaCita();

	std::cout << "\n--- Se marca la vacuna ---" << std::endl;
	miMascota.vacunar();
	miMascota.vacunado();

	std::cout << "\n--- Se marca una cita realizada hoy ---" << std::endl;
	miMascota.marcarCitaRealizada();
	miMascota.obtenerFechaUltimaVisita();
	miMascota.verificarProximaCita();

	return 0;
}