using AlmacenLocal.Modelos;

public class Program
{
    static void Main()
    {
        List<Producto> listaProductos = new List<Producto>();

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
                    listaProductos.Add(productito);
                    Console.WriteLine("Producto agregado a la lista de productos\n");
                    break;
                case 2:
                    Console.WriteLine("Elige el producto para modificar la cantidad de stock");
                    for (int i = 0; i < listaProductos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - Nombre del producto: {listaProductos[i].Nombre}, Codigo: {listaProductos[i].Codigo}, " +
                            $"Cantidad en Stock: {listaProductos[i].CantidadStock}");    
                    }
                    int numero = int.Parse(Console.ReadLine()) - 1;
                    if(numero >=0 && numero < listaProductos.Count)
                    {
                        Console.Write("Ingresar la cantida de stock actualizada: ");
                        int stock = int.Parse(Console.ReadLine());
                        listaProductos[numero].CantidadStock = stock;
                        Console.WriteLine("Cantidad en stock actualizada");
                    }
                    else
                    {
                        Console.WriteLine("Numero de producto no válido");
                    }
                    Console.WriteLine("\n");
                    break;
                case 3:
                    for (int i = 0; i < listaProductos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - Nombre del producto: {listaProductos[i].Nombre}, Codigo: {listaProductos[i].Codigo}, " +
                            $"Cantidad en Stock: {listaProductos[i].CantidadStock}");
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