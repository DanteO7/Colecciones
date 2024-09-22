using AlmacenLocal.Modelos;

public class Program
{
    static void Main()
    {
        Dictionary<string, Producto> listaProductos = new Dictionary<string, Producto>();

        int opcion;

        do
        {
            Console.WriteLine("1 - Agregar un nuevo producto");
            Console.WriteLine("2 - Actualizar la cantidad en stock de un producto");
            Console.WriteLine("3 - Mostrar todos los productos en stock");
            Console.WriteLine("4 - Salir\n");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombreProducto = Console.ReadLine();

                    Console.Write("Ingrese el codigo del producto: ");
                    string codigoProducto = Console.ReadLine();

                    Console.Write("Ingrese la cantidad de stock del producto: ");
                    int cantidadStock = int.Parse(Console.ReadLine());

                    Producto productito = new Producto(nombreProducto, codigoProducto, cantidadStock);
                    listaProductos.TryAdd(codigoProducto, productito);
                    Console.WriteLine("Producto agregado a la lista de productos\n");
                    break;
                case 2:
                    Console.Write("Ingrese el codigo del producto que desea actualizar la cantidad en stock: ");
                    string cod = Console.ReadLine();
                    if (listaProductos.ContainsKey(cod))
                    {
                        Console.Write("Ingrese la nueva cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        listaProductos[cod].CantidadStock = cantidad;
                        Console.WriteLine("Cantidad en stock actualizada");
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado");
                    }
                    break;
                case 3:
                    Console.WriteLine("Productos en stock: ");
                    foreach (var producto in listaProductos.Values)
                    {
                        Console.WriteLine($"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Cantidad: {producto.CantidadStock}");
                    }
                    break;
            }
        }
        while (opcion != 4);

        Console.WriteLine("Pulse cualquier tecla para salir");
        Console.ReadKey();
    }
}