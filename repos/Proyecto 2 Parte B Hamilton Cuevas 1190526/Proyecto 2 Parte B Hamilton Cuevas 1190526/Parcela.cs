using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2_Parte_B_Hamilton_Cuevas_1190526
{
    // Clase Parcela que representa cada parcela en el juego
    internal class Parcela
    {
        public int tipoSiembra;
        public int edadMeses;
        public int mesesParaCrecer;
        public double ingresoCosecha;
        public bool tieneFertilizante;
        public bool yaFertilizada;
        public bool estaOcupada;
        public string estado;
        // Constructor para inicializar la parcela
        public Parcela(int tipoSiembra, int edadMeses, int mesesParaCrecer, double ingresoCosecha, bool tieneFertilizante, bool yaFertilizada, bool estaOcupada)
        {
            this.tipoSiembra = tipoSiembra;
            this.edadMeses = edadMeses;
            this.mesesParaCrecer = mesesParaCrecer;
            this.ingresoCosecha = ingresoCosecha;
            this.tieneFertilizante = tieneFertilizante;
            this.yaFertilizada = yaFertilizada;
            this.estaOcupada = estaOcupada;
            this.estado = "|-|"; 
        }
        // Método para mostrar el estado de la parcela
        public void MostrarEstado()
        {
            string tipo = tipoSiembra == 1 ? "Maíz" : tipoSiembra == 2 ? "Zanahoria" : tipoSiembra == 3 ? "Lechuga" : "Vacía";
            Console.WriteLine($"Tipo de Siembra: {tipo}");
            Console.WriteLine($"Edad en Meses: {edadMeses}");
            Console.WriteLine($"Meses para Crecer: {mesesParaCrecer}");
            Console.WriteLine($"Ingreso por Cosecha: Q{ingresoCosecha}");
            Console.WriteLine($"Tiene Fertilizante: {tieneFertilizante}");
            Console.WriteLine($"Ya Fertilizada: {yaFertilizada}");
            Console.WriteLine($"Está Ocupada: {estaOcupada}");
        }
    }
}