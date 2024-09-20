using ListaDeTareas.Modulos;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

public class Program
{
    public static void MostrarTareasPendientes(List<Tarea> tareas)
    {
        for (int i = 0; i < tareas.Count; i++)
        {
            if (!tareas[i].IsCompletada)
            {
                Console.WriteLine($"{i + 1} - {tareas[i].Descripcion}");
            }
        }
    }

    public static void MostrarTareasCompletas(List<Tarea> tareas)
    {
        for (int i = 0; i < tareas.Count; i++)
        {
            if (tareas[i].IsCompletada)
            {
                Console.WriteLine($"{i + 1} - {tareas[i].Descripcion}");
            }
        }
    }
    public static void MostrarTodasLasTareas(List<Tarea> tareas)
    {
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {tareas[i].Descripcion}, Estado: {(tareas[i].IsCompletada ? "Completa" : "Pendiente")}");
        }
    }

    public static bool ValidacionTareaCompletada(List<Tarea> tareas)
    {
        foreach(var tarea in tareas)
        {
            if (tarea.IsCompletada)
            {
                return true;
            }
        }
        return false;
    }
    public static bool ValidacionTareaPendiente(List<Tarea> tareas)
    {
        foreach (var tarea in tareas)
        {
            if (!tarea.IsCompletada)
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        List<Tarea> tareas = new List<Tarea>();

        int opcion;
        int numero;

        do
        {
            Console.WriteLine("1 - Agregar nueva tarea");
            Console.WriteLine("2 - Marcar una tarea como completada");
            Console.WriteLine("3 - Mostrar tareas pendientes");
            Console.WriteLine("4 - Mostrar tareas completadas");
            Console.WriteLine("5 - Mostrar todas las tareas");
            Console.WriteLine("6 - Modificar una tarea");
            Console.WriteLine("7 - Descompletar una tarea");
            Console.WriteLine("8 - Salir\n");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la tarea");
                    string descripcion = Console.ReadLine();
                    Tarea tareita = new Tarea(descripcion);
                    tareas.Add(tareita);
                    break;
                case 2:
                    if (ValidacionTareaPendiente(tareas))
                    {
                        Console.WriteLine("Elige tarea para marcar como completada");
                        MostrarTareasPendientes(tareas);
                        Console.Write("\nTarea: ");
                        numero = int.Parse(Console.ReadLine()) - 1;
                        if(numero >= 0 && numero < tareas.Count)
                        {
                            tareas[numero].IsCompletada = true;
                            Console.WriteLine($"Tarea {tareas[numero].Descripcion} marcada como compeltada");
                        }
                        else
                        {
                            Console.WriteLine("Numero de tarea invalido");
                        }
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay tareas pendientes para marcar como completadas\n");
                    }

                    break;
                case 3:
                    if (ValidacionTareaPendiente(tareas))
                    {
                        Console.WriteLine("Tareas Pendientes:");
                        MostrarTareasPendientes(tareas);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay tareas pendientes\n");
                    }
                    break;
                case 4:
                    if (ValidacionTareaCompletada(tareas))
                    {
                        Console.WriteLine("Tareas Completadas:");
                        MostrarTareasCompletas(tareas);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay tareas Completadas\n");
                    }
                    break;
                case 5:
                    Console.WriteLine("Todas las tareas:");
                    MostrarTodasLasTareas(tareas);
                    Console.WriteLine("\n");
                    break;
                case 6:
                    Console.WriteLine("Elige tarea para modificar su descripcion:");
                    MostrarTodasLasTareas(tareas);
                    Console.Write("\nTarea: ");
                    numero = int.Parse(Console.ReadLine()) - 1;
                    if (numero >= 0 && numero < tareas.Count)
                    {
                        Console.Write("Ingrese la nueva descripcion: ");
                        string nuevaDescripcion = Console.ReadLine();
                        tareas[numero].EditarTarea(nuevaDescripcion);
                    }
                    else
                    {
                        Console.WriteLine("Numero de tarea invalido\n");
                    }
                    Console.WriteLine("\n");
                    break;
                case 7:
                    if (ValidacionTareaCompletada(tareas))
                    {
                        Console.WriteLine("Elige tarea para descompletarla");
                        MostrarTareasCompletas(tareas);
                        Console.Write("\nTarea: ");
                        numero = int.Parse(Console.ReadLine()) - 1;
                        if (numero >= 0 && numero < tareas.Count)
                        {
                            tareas[numero].IsCompletada = false;
                            Console.WriteLine($"Tarea: {tareas[numero].Descripcion} marcada como descompletada\n");
                        }
                        else
                        {
                            Console.WriteLine("Numero de tarea invalido\n");
                        }
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay tareas completadas para descompletar\n");
                    }
                    break;
            }
        }
        while (opcion != 8);

        Console.WriteLine("Pulse cualquier tecla para salir");
        Console.ReadKey();
    }
}