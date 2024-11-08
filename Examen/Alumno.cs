
namespace Examen
{
    public class Alumno : IAsignatura{
        public string NombreAlumno { get; set; }
        public string NumeroCuenta { get; set; }
        public string Email { get; set; }

        public double CalcularNotaFinal(){
            return CalcularNotaFina(0, 0, 0);
        }

        public double CalcularNotaFina(double N1, double N2, double N3){
            return N1 + N2 + N3;
        }

        public void Imprimir(){

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electronico: {Email}");
           
        }

        public void MensajeNotaFinal(double notaFinal){

             if (notaFinal >= 0 && notaFinal <= 59){

                Console.WriteLine("Reprobado");
             }
             else if (notaFinal >= 60 && notaFinal <= 79){

                Console.WriteLine("Bueno");
             }
             else if (notaFinal >= 80 && notaFinal <= 89){

                Console.WriteLine("Muy Bueno");
             }
             else if (notaFinal >= 90 && notaFinal <= 100){

                Console.WriteLine("Sobresaliente");
             }
             else{
                Console.WriteLine("Nota fuera de rango");
             }

        }
    }
}
