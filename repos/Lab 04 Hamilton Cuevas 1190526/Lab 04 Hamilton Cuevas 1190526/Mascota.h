#ifndef MASCOTA_H
#define MASCOTA_H
#include <string>
#include <ctime>

using namespace std;

struct Mascota {
	string nombre;
	string especie;
	string nombreDueno;
	time_t horaIngreso;
	time_t horaSalida;
	double precioConsulta;

	Mascota(string n, string e, string nd, double precio)
		: nombre(n), especie(e), nombreDueno(nd), precioConsulta(precio), horaSalida(0) {
		horaIngreso = time(nullptr);
	}

	void setHoraSalida() {
		horaSalida = time(nullptr);
	}

	double cobro() {
		return precioConsulta;
	}

	string formatearHora(time_t t) {
		if (t == 0) return "Aun no registrada";

		tm horaLocal;
		localtime_s(&horaLocal, &t);

		char buffer[9];
		strftime(buffer, sizeof(buffer), "%H:%M:%S", &horaLocal);

		return string(buffer);
	}
};

#endif // !MASCOTA_H