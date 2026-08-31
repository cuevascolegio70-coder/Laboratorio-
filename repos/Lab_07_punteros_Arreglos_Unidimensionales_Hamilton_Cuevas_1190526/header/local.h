#ifndef LOCAL_H
#define LOCAL_H

#include "Sucursal.h"

class Local : public Sucursal {
private:
    double fondo;
    double ancho;

public:
    Local(const std::string& nombre = "", const std::string& direccion = "", double montoVentas = 0.0, double fondo = 0.0, double ancho = 0.0);

    void setFondo(double fondo);
    double getFondo() const;

    void setAncho(double ancho);
    double getAncho() const;

    // Sobrescritura del método
    std::string obtenerInformacion() const override;
};

#endif // LOCAL_H