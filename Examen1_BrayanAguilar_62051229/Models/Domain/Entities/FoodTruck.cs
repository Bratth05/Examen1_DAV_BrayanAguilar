namespace Examen1_BrayanAguilar_62051229.Models.Domain.Entities
{
    public class FoodTruck
    {
        public Guid Id { get; private set; }
        public string Nombre { get; private set; }
        public string UbicacionActual { get; private set; }

        public FoodTruck(Guid id, string nombre, string ubicacionActual)
        {
            Id = id;
            Nombre = nombre;
            UbicacionActual = ubicacionActual;
        }

        public void ActualizarUbicacion(string nuevaUbicacion)
        {
            UbicacionActual = nuevaUbicacion;
        }
    }
}
