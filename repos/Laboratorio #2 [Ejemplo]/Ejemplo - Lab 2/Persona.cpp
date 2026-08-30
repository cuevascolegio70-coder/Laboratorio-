#include "pch.h"
#include <iostream>
#include "Persona.h"

// Constructor de la clase Persona
// Este constructor inicializa los atributos de la persona (nombre, edad, género, y país)
Persona::Persona(std::string n, int e, char g, std::string p) {
    nombre = n;  // Inicializa el atributo nombre con el valor pasado
    edad = e;    // Inicializa el atributo edad con el valor pasado
    genero = g;  // Inicializa el atributo genero con el valor pasado
    pais = p;    // Inicializa el atributo pais (público) con el valor pasado
}

// Método para obtener el nombre de la persona
std::string Persona::obtenerNombre() {
    return nombre;  // Devuelve el nombre de la persona
}

// Método para obtener la edad de la persona
int Persona::obtenerEdad() {
    return edad;  // Devuelve la edad de la persona
}

// Método para obtener el género de la persona
char Persona::obtenerGenero() {
    return genero;  // Devuelve el género de la persona (M o F)
}

// Método para mostrar toda la información de la persona en la consola
void Persona::mostrarInformacion() {
    // Muestra el nombre de la persona
    std::cout << "Nombre: " << nombre << std::endl;

    // Muestra la edad de la persona
    std::cout << "Edad: " << edad << std::endl;

    // Muestra el género de la persona, basado en el valor de 'genero'
    std::cout << "Género: " << (genero == 'M' ? "Masculino" : "Femenino") << std::endl;

    // Muestra el país de la persona
    std::cout << "País: " << pais << std::endl;
}
