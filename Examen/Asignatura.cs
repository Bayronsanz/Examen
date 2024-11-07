using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Asignatura : IAsignatura {
        int N1 { get; set; }
        int N2 { get; set; }
        int N3 { get; set; }
        string NombreAsignatura { get; set; }
        string Horario {  get; set; }
        string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(double N1, double N2, double N3)
        {
            return N1+N2+N3;
        }

        public void Imprimir()
        {
            Console.WriteLine("Ingrese nombre del alumno: ");
            Console.WriteLine("Ingrese numero de cuenta: ");
            Console.WriteLine("Ingrese Correo electronico: ");
            Console.WriteLine("Ingrese nombre de la clase: ");
            Console.WriteLine("Ingrese Horario de la clase: ");
            Console.WriteLine("Ingrese el nombre del docente: ");
            Console.WriteLine();
            Console.WriteLine("Ingrese la nota del primer parcial: ");
            Console.WriteLine("Ingrese la nota del primer parcial: ");
            Console.WriteLine("Ingrese la nota del primer parcial: ");

        }

        public void MensajeNotaFinal(double notaFinal)
        {
            Console.WriteLine("Introduce la nota en porcentaje (0-100):");
            notaFinal=Convert.ToDouble(Console.ReadLine());

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
