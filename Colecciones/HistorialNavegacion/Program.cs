public class Program
{
    static void Main()
    {
        Stack<string> historial = new Stack<string>();


        int opcion;

        do
        {
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("1 - Agregar una nueva pagina al historial");
            Console.WriteLine("2 - Retroceder a la pagina anterior");
            Console.WriteLine("3 - Mostrar historial completo");
            Console.WriteLine("4 - Salir\n");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la url de la pagina: ");
                    string url = Console.ReadLine();
                    historial.Push(url);
                    Console.WriteLine($"Visitando: {url}\n");
                    break;
                case 2:
                    if (historial.Count > 0)
                    {
                        string paginaAnterior = historial.Pop();
                        Console.WriteLine($"Retrocediendo desde {paginaAnterior}\n");
                    }
                    else
                    {
                        Console.WriteLine("No hay mas Paginas en el historial");
                    }
                    break;
                case 3:
                    Console.WriteLine("Historial de Navegacion:");
                    foreach(var pagina in historial)
                    {
                        Console.WriteLine(pagina);
                    }
                    Console.WriteLine("\n");
                    break;
            }
        }
        while (opcion != 4);

        Console.WriteLine("Pulse cualquier tecla para salir");
        Console.ReadKey();
    }
}