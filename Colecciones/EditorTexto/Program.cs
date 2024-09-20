public class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un texto:");
        string texto = Console.ReadLine();

        Dictionary<string,int> contadorPalabras = new Dictionary<string,int>();
        
        string[] palabras = texto.Split(' ');

        foreach (string palabra in palabras)
        {
            if (contadorPalabras.ContainsKey(palabra))
            {
                contadorPalabras[palabra]++;
            }
            else
            {
                contadorPalabras.Add(palabra, 1);
            }            
        }

        Console.WriteLine("\nFrecuencia de palabras: ");
        foreach (var entrada in contadorPalabras)
        {
            Console.WriteLine($"{entrada.Key}: {entrada.Value}");
        }

        //int opcion;

        //do
        //{
        //    Console.WriteLine("1 - Leer cadena de texto y separar las palabras");
        //    Console.WriteLine("2 - Contar cuantas veces aparece cada palabra");
        //    Console.WriteLine("3 - Mostrar la lista de palabras junto con su frecuencia");
        //    Console.WriteLine("4 - Salir\n");

        //    opcion = int.Parse(Console.ReadLine());

        //    switch (opcion)
        //    {
        //        case 1:
        //            Console.WriteLine("\n");
        //            break;
        //        case 2:
        //            Console.WriteLine("\n");
        //            break;
        //        case 3:
        //            Console.WriteLine("\n");
        //            break;
        //    }
        //}
        //while (opcion != 4);

        //Console.WriteLine("Pulse cualquier tecla para salir");
        //Console.ReadKey();
    }
}



/*Un almacén local necesita un sistema que le permita gestionar sus productos. Cada producto tiene un código único, un nombre y una cantidad en stock.

El sistema debe permitir:
1. Agregar un nuevo producto.
2. Actualizar la cantidad en stock de un producto dado su código.
3. Mostrar todos los productos en stock.*/