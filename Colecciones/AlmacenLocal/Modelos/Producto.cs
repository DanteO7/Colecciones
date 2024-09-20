namespace AlmacenLocal.Modelos
{
    public class Producto   
    {
        public string Nombre { get; private set; }
        public string Codigo { get; private set; }
        public int CantidadStock { get; set; }

        public Producto(string nombre, string codigo, int cantidadStock)
        {
            Nombre = nombre;
            Codigo = codigo;
            CantidadStock = cantidadStock;
        }
    }
}
