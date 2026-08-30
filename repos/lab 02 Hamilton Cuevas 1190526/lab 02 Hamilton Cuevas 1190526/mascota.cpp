#include "pch.h"
#include <iostream>
#include <ctime>
#include "mascota.h"

Mascota::Mascota(std::string especie, std::string nombre, std::string fechaNacimiento, time_t fechaUltimaVisita, bool Vacunado, std::string nombreDueño, std::string telefono) {
	this->especie = especie;
	this->nombre = nombre;
	this->fechaNacimiento = fechaNacimiento;
	this->fechaUltimaVisita = fechaUltimaVisita;
	this->Vacunado = Vacunado;
	this->nombreDueño = nombreDueño;
	this->telefono = telefono;
}

void Mascota::vacunar() {
	Mascota::Vacunado = true;
}

void Mascota::verificarProximaCita() {
	if (fechaUltimaVisita == 0) {
		std::cout << "La mascota no ha tenido ninguna cita, debe agendar una." << std::endl;
		return;
	}

	time_t ahora = time(0);
	double segundosTranscurridos = difftime(ahora, fechaUltimaVisita);
	double diasTranscurridos = segundosTranscurridos / (60 * 60 * 24);

	if (diasTranscurridos >= 30) {
		std::cout << "Ya han pasado " << (int)diasTranscurridos << " dias desde la ultima cita. Debe agendar una nueva." << std::endl;
		std::cout << "Telefono del dueño: " << telefono << std::endl;
		std::cout << "Nombre del dueño: " << nombreDueño << std::endl;
	}
	else {
		std::cout << "Han pasado " << (int)diasTranscurridos << " dias desde la ultima cita." << std::endl;
	}
}

void Mascota::obtenerEspecie() {
	std::cout << "La especie de la mascota es: " << especie << std::endl;
}

void Mascota::obtenerNombre() {
	std::cout << "El nombre de la mascota es: " << nombre << std::endl;
}

void Mascota::obtenerFechaNacimiento() {
	std::cout << "La fecha de nacimiento de la mascota es: " << fechaNacimiento << std::endl;
}

void Mascota::obtenerFechaUltimaVisita() {
	if (fechaUltimaVisita == 0) {
		std::cout << "La mascota no ha tenido ninguna visita." << std::endl;
		return;
	}
	tm* fechaLocal = localtime(&fechaUltimaVisita);
	std::cout << "La fecha de la ultima visita de la mascota es: "
		<< fechaLocal->tm_mday << "/"
		<< (fechaLocal->tm_mon + 1) << "/"
		<< (fechaLocal->tm_year + 1900) << std::endl;
}

void Mascota::obtenernombreDueño() {
	std::cout << "El nombre del dueño de la mascota es: " << nombreDueño << std::endl;
}

void Mascota::obtenerTelefono() {
	std::cout << "El telefono del dueño de la mascota es: " << telefono << std::endl;
}

void Mascota::marcarCitaRealizada() {
	fechaUltimaVisita = time(0);
}

void Mascota::vacunado() {
	std::cout << Vacunado << std::endl;
}


