using System.Threading;

namespace ListaDeTareas.Modulos
{
    public class Tarea
    {
        public string Descripcion { get; private set; }
        public bool IsCompletada { get; set; }

        public Tarea(string descripcion)
        {
            Descripcion = descripcion;
        }

        public void EditarTarea(string nuevaDescripcion)
        {
            Console.WriteLine($"Descripcion modoficada de {Descripcion} a {nuevaDescripcion}\n");
            Descripcion = nuevaDescripcion;
        }
    }
}
