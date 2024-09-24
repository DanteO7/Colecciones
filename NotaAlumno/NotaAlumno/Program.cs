public class Alumno
{
    public string Nombre { get; private set; }
    public double Nota { get; set; }
    public Alumno(string nombre, double nota)
    {
        Nombre = nombre;
        Nota = nota;
    }
}

public static class SistemaAlumno
{
    private static Dictionary<string, double> ListaAlumno = new Dictionary<string, double>();

    public static void AgregarAlumno(Alumno alumno)
    {
        if (ListaAlumno.ContainsKey(alumno.Nombre))
        {
            Console.WriteLine("Ya se encuentra ese alumno registrado\n");
        }
        else
        {
            ListaAlumno.TryAdd(alumno.Nombre, alumno.Nota);
            Console.WriteLine("Alumno Agregado\n");
        }
    }

    public static void MostrarNotas()
    {
        if(ListaAlumno.Count == 0)
        {
            Console.WriteLine("No hay estudiantes agregados\n");
            return;
        }
        foreach(var alumno  in ListaAlumno)
        {
            Console.WriteLine($"Alumno: {alumno.Key}, Nota: {alumno.Value}");
        }
        Console.WriteLine("\n");
    }

    public static void ModificarNota()
    {
        if (ListaAlumno.Count == 0)
        {
            Console.WriteLine("No hay estudiantes agregados\n");
            return;
        }

        Console.Write("Ingrese el nombre del alumno para modificar: ");
        string nombreAlumno = Console.ReadLine();

        if (ListaAlumno.ContainsKey(nombreAlumno))
        {
            Console.Write("Ingresar nota nueva para el alumno: ");
            double notaNueva = double.Parse(Console.ReadLine());

            ListaAlumno[nombreAlumno] = notaNueva;
            Console.WriteLine("Nota actualizada\n");
        }
        else
        {
            Console.WriteLine("Alumno no encontrado\n");
        }
    }
}

public class Program
{
    static void Main()
    {

        int opcion;
        do
        {
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine("Menu: ");
            Console.WriteLine($"1). Agregar nuevo alumno. ");
            Console.WriteLine($"2). Consultar notas. ");
            Console.WriteLine($"3). Modificar calificacion. ");
            Console.WriteLine($"4). Salir. ");
            Console.WriteLine($"-------------------------------------- \n");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre del alumno: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la nota del alumno: ");
                    double nota = double.Parse(Console.ReadLine());

                    Alumno alumno = new Alumno(nombre, nota);

                    SistemaAlumno.AgregarAlumno (alumno);
                    break;
                case 2:
                    SistemaAlumno.MostrarNotas();
                    break;
                case 3:
                    SistemaAlumno.ModificarNota();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del Programa....");
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion válida\n");
                    break;
            }
        }
        while (opcion != 4);
    }
}