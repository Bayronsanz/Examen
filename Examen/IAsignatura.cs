using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IAsignatura {
        public double CalcularNotaFinal();
        public double CalcularNotaFina (double N1, double N2, double N3);
        public void MensajeNotaFinal(double notaFinal);
        public void Imprimir();
        string NombreAlumno {  get; set; } 
    }
}
