using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : Alumno {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario {  get; set; }
        public string NombreDocente { get; set; }
       
        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFina(double N1, double N2, double N3)
        {
            return N1+N2+N3;
        }

        public void Imprimir(){

            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota final con los parametros: {CalcularNotaFina(N1, N2, N3)}");
            Console.WriteLine($"Nota final: {CalcularNotaFinal()}");
            Console.WriteLine($"*************************************************");
            double notaFinal = CalcularNotaFinal();
            MensajeNotaFinal(notaFinal);
        }

        public void MensajeNotaFinal(double notaFinal)
        {
            if (N1 < 0 || N1 > 30)
            {
                Console.WriteLine("La nota del primer parcial no es válida. Debe estar entre 0 y 30.");
                return;
            }
            if (N2 < 0 || N2 > 30)
            {
                Console.WriteLine("La nota del segundo parcial no es válida. Debe estar entre 0 y 30.");
                return;
            }
            if (N3 < 0 || N3 > 40)
            {
                Console.WriteLine("La nota del tercer parcial no es válida. Debe estar entre 0 y 40.");
                return;
            }
            if (notaFinal >= 0 && notaFinal <= 59)
            {
                Console.WriteLine("Reprobado");
            }
            else if (notaFinal >= 60 && notaFinal <= 79)
            {
                Console.WriteLine("Bueno");
            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {
                Console.WriteLine("Muy Bueno");
            }
            else if (notaFinal >= 90 && notaFinal <= 100)
            {
                Console.WriteLine("Sobresaliente");
            }
            else
            {
                Console.WriteLine("Nota fuera de rango");
            }

        }
    }
}
