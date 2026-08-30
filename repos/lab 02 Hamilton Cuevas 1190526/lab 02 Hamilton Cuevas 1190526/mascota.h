#ifndef MASCOTA_H
#define MASCOTA_H

#include <string>
#include <ctime>

class Mascota {
public:
	std::string especie;
	std::string nombre;
	std::string fechaNacimiento;
	time_t fechaUltimaVisita = 0;
	bool Vacunado;
	std::string nombreDueño;
	std::string telefono;

public:
	Mascota(std::string especie, std::string nombre, std::string fechaNacimiento, time_t fechaUltimaVisita, bool Vacunado, std::string nombreDueño, std::string telefono);
	void obtenerEspecie();
	void obtenerNombre();
	void obtenerFechaNacimiento();
	void obtenerFechaUltimaVisita();
	void obtenernombreDueño();
	void obtenerTelefono();
	void marcarCitaRealizada();
	void vacunado();
	void vacunar();
	void verificarProximaCita();
};

#endif // !MASCOTA_H
