#ifndef SUCURSAL_H
#define SUCURSAL_H

#include <string>

class Sucursal {
protected:
    std::string nombre;
    std::string direccion;
    double montoVentas;

public:
    // Constructor
    Sucursal(const std::string& nombre = "", const std::string& direccion = "", double montoVentas = 0.0);
    virtual ~Sucursal();

    // Métodos para consultar y modificar atributos
    void setNombre(const std::string& nombre);
    std::string getNombre() const;

    void setDireccion(const std::string& direccion);
    std::string getDireccion() const;

    void setMontoVentas(double montoVentas);
    double getMontoVentas() const;

    // Método para acumular ventas
    void acumularVentas(double monto);

    // Método virtual para polimorfismo
    virtual std::string obtenerInformacion() const;
};

#endif // SUCURSAL_H