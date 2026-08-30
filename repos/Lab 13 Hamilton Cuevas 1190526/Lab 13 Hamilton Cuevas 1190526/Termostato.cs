using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Hamilton_Cuevas_1190526
{
    public class Termostato
    {
        string ubicacion;
        double temperatura;

        public Termostato(string ubicacion, double temperatura)
        {
            this.ubicacion = ubicacion;
            this.temperatura = temperatura;
        }

        public void ajustarTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Ubicación: {ubicacion}");
            Console.WriteLine($"Temperatura: {temperatura}°C");
        }





    }

   
}
