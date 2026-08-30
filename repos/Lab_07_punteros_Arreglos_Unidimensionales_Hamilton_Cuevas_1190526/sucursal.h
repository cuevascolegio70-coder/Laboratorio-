#ifndef Sucursal_H
#define Sucursal_H
#include <string>

using namespace std;

class Sucursal {
    protected:
        string nombre;
        string direccion;
        double MontoVentas;


    public:
        Sucursal(string nombre, string direccion, double MontoVentas);

        virtual double getMontoVentas() const;

        virtual void getinfo() const;

        virtual string getNombre() const;

        virtual string getDireccion() const;
};





#endif