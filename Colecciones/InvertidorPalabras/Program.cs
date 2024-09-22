public class Program
{
    static void Main()
    {
        Console.Write("Ingrese un texto para invertirlo: ");
        string textoUsuario = Console.ReadLine();

        Stack<char> pila = new Stack<char>();

        foreach(var caracter in textoUsuario)
        {
            pila.Push(caracter);
        }
        Console.Write("Frase invertida: ");
        while (pila.Count > 0)
        {
            Console.Write(pila.Pop());
        }
    }
}