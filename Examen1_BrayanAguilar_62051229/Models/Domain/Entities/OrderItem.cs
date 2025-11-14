namespace Examen1_BrayanAguilar_62051229.Models.Domain.Entities
{
    public class OrderItem
    {
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }
        public int Cantidad { get; private set; }

        public OrderItem(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public decimal Subtotal => Precio * Cantidad;
    }
}
