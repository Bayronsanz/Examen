using Examen;

try
{
    string NombreAlumno, NumeroCuenta, Email;
    string NombreAsignatura, Horario, NombreDocente;
    int N1, N2, N3;

    Alumno alumno= new Alumno();
    Asignatura asignatura= new Asignatura();

    Console.WriteLine("Ingrese nombre del alumno: ");
    NombreAlumno = Console.ReadLine();
    alumno.NombreAlumno = NombreAlumno;

    Console.WriteLine("Ingrese numero de cuenta: ");
    NumeroCuenta = Console.ReadLine();
    alumno.NumeroCuenta = NumeroCuenta;

    Console.WriteLine("Ingrese Correo electronico: ");
    Email = Console.ReadLine();
    alumno.Email = Email;

    Console.WriteLine("Ingrese nombre de la clase: ");
    NombreAsignatura = Console.ReadLine();
    asignatura.NombreAsignatura = NombreAsignatura;

    Console.WriteLine("Ingrese Horario de la clase: ");
    Horario = Console.ReadLine();
    asignatura.Horario = Horario;

    Console.WriteLine("Ingrese el nombre del docente: ");
    NombreDocente = Console.ReadLine();
    asignatura.NombreDocente= NombreDocente;

    Console.WriteLine("Ingrese la nota del primer parcial (0-30): ");
    N1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la nota del segundo parcial (0-30): ");
    N2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la nota del tercer parcial (0-40): ");
    N3 = Convert.ToInt32(Console.ReadLine());

    asignatura.N1 = N1;
    asignatura.N2 = N2;
    asignatura.N3 = N3;

    alumno.Imprimir();
    asignatura.Imprimir();

}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error: {ex.Message}");
}
