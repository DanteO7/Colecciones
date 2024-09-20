namespace Banco.Modelo
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int NumeroDeCliente { get; set; }

        public Cliente(string nombre, int numeroDeCliente)
        {
            Nombre = nombre;
            NumeroDeCliente = numeroDeCliente;
        }
    }
}
