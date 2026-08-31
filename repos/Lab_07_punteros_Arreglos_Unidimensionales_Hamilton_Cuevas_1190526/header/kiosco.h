#ifndef KIOSCO_H
#define KIOSCO_H

#include "Sucursal.h"

class Kiosco : public Sucursal {
private:
    double renta;

public:
    Kiosco(const std::string& nombre = "", const std::string& direccion = "", double montoVentas = 0.0, double renta = 0.0);

    void setRenta(double renta);
    double getRenta() const;

    // Sobrescritura del método
    std::string obtenerInformacion() const override;
};

#endif // KIOSCO_H