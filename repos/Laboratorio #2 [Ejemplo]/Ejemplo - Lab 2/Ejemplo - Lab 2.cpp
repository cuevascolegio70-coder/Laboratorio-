#include "pch.h"
#include <iostream>
#include "Persona.h"

using namespace System;

int main(array<System::String ^> ^args)
{
    // Crear un objeto de tipo Persona con los datos iniciales: nombre, edad, género, y país
    Persona persona1("Juan Pérez", 30, 'M', "Guatemala");
    Persona persona2("Ana Gómez", 25, 'F', "México");

    // Mostrar la información de la Persona 1 utilizando el método mostrarInformacion()
    std::cout << "Información de la Persona 1:" << std::endl;
    persona1.mostrarInformacion();

    // Mostrar la información de la Persona 2 utilizando el mismo método
    std::cout << "\nInformación de la Persona 2:" << std::endl;
    persona2.mostrarInformacion();

    // Modificar el país de la persona1, como el atributo 'pais' es público, podemos modificarlo directamente
    persona1.pais = "Argentina";  // Modificación directa de un atributo público

    // Mostrar la información actualizada de la Persona 1 después de cambiar el país
    std::cout << "\nInformación actualizada de la Persona 1:" << std::endl;
    persona1.mostrarInformacion();

    return 0;  // Fin del programa
}
