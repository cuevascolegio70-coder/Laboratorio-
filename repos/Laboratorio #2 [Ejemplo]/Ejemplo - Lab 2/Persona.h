//Siempre es buena idea usar macros del preprocesador para evitar compilar varias veces el mismo archivo

#ifndef PERSONA_H // #ifndef (If Not Defined): Si no está definido el símbolo o nombre, el código que sigue a esta directiva se incluirá. Si ya está definido, se saltará esa parte del código.
#define PERSONA_H // #define: Este símbolo se usará para garantizar que un archivo de encabezado se procese solo una vez.

#include <string>

class Persona {
private:
    // Atributos privados: No accesibles directamente desde fuera de la clase
    std::string nombre;  // Nombre de la persona
    int edad;            // Edad de la persona
    char genero;         // Género de la persona ('M' para masculino, 'F' para femenino)

public:
    // Atributo público: Puede ser accesible directamente desde fuera de la clase
    std::string pais;    // País de residencia de la persona (público para simplicidad)

    // Constructor: Inicializa los valores de los atributos
    Persona(std::string n, int e, char g, std::string p);

    // Métodos públicos para acceder a los atributos privados
    std::string obtenerNombre();
    int obtenerEdad();
    char obtenerGenero();

    // Método público para mostrar la información de la persona
    void mostrarInformacion();
};

#endif
