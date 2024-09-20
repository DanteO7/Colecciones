using Banco.Modelo;

public class Program
{
    static void Main()
    {
        Queue<Cliente> colaClientes = new Queue<Cliente>();
        
        int opcion;

        do
        {
            Console.WriteLine("1 - Agregar cliente a la cola");
            Console.WriteLine("2 - Atender cliente");
            Console.WriteLine("3 - Mostrar clientes en la cola");
            Console.WriteLine("4 - Salir\n");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre del cliente: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el número del cliente: ");
                    int numero = int.Parse(Console.ReadLine());

                    Cliente cliente = new Cliente(nombre, numero);
                    colaClientes.Enqueue(cliente);
                    Console.WriteLine("\n");
                    break;
                case 2:
                    if(colaClientes.Count > 0)
                    {
                        Cliente clienteAtendido = colaClientes.Dequeue();
                        Console.WriteLine($"Atendiendo a: {clienteAtendido.Nombre}, {clienteAtendido.NumeroDeCliente}");
                    }
                    else
                    {
                        Console.WriteLine("No hay clientes en la cola");
                    }
                    break;
                case 3:
                    Console.WriteLine("Clientes en la cola:");
                    foreach(var c in colaClientes)
                    {
                        Console.WriteLine($"{c.Nombre}, {c.NumeroDeCliente}");
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