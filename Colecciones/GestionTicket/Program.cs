public class Ticket
{
    public int Id { get; private set; }
    public string Descripcion { get; private set; }
    public Ticket(int id, string descripcion)
    {
        Id = id;
        Descripcion = descripcion;
    }
}

public static class SistemaTicket
{
    private static Queue<Ticket> ColaDeTickets = new Queue<Ticket>();
    private static int SiguienteID = 1;
    
    public static void AgregarTicket(string descripcion)
    {
        Ticket ticket = new Ticket(SiguienteID++, descripcion);
        ColaDeTickets.Enqueue(ticket);
        Console.WriteLine($"El ticket #{ticket.Id}: {ticket.Descripcion}, fue agregado a la cola\n");
    }

    public static void ProcesarTicket()
    {
        if(ColaDeTickets.Count > 0)
        {
            Ticket ticket = ColaDeTickets.Dequeue();
            Console.WriteLine($"Procesando Ticket #{ticket.Id}: {ticket.Descripcion}\n");
        }
        else
        {
            Console.WriteLine("No hay mas ticket para procesar\n");
        }
    }

    public static void MostrarTickets()
    {
        if(ColaDeTickets.Count == 0)
        {
            Console.WriteLine("No hay mas tickets\n");
            return;
        }
        Console.WriteLine("Tickets pendientes: \n");
        foreach (Ticket ticket in ColaDeTickets)
        {
            Console.WriteLine($"Ticket #{ ticket.Id}: { ticket.Descripcion}");
        }
        Console.WriteLine("\n");
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
            Console.WriteLine("Menu:  ");
            Console.WriteLine($"1). Agregar nuevo ticket. ");
            Console.WriteLine($"2). Ver tickets pendientes. ");
            Console.WriteLine($"3). Prosesar el ticket siguiente. ");
            Console.WriteLine($"4). Salir. ");
            Console.WriteLine($"-------------------------------------- \n");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n");
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la descripción del ticket");
                    string descripcion = Console.ReadLine();
                    SistemaTicket.AgregarTicket(descripcion);
                    break;
                case 2:
                    SistemaTicket.MostrarTickets();
                    break;
                case 3:
                    SistemaTicket.ProcesarTicket();
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