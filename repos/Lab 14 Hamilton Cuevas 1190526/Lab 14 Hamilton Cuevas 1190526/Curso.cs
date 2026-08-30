using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Lab_14_Hamilton_Cuevas_1190526
{
    internal class Curso
    {
        
        public string curso;
        public double notaFinal;

        public Curso(string curso, double notaFinal)
        {
            this.curso = curso;
            this.notaFinal = notaFinal;
            
        }
    }
}
