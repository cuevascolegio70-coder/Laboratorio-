using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14_Hamilton_Cuevas_1190526
{
    class Estudiante
    {
        public Curso[] cursos = new Curso[2];
        public string nombre;
        public string carnet;
        public string curso;
        public Estudiante(string nombre, string carnet, Curso[] cursos)
        {
            this.nombre = nombre;
            this.carnet = carnet;
            this.cursos = cursos;
        }
    }
}
