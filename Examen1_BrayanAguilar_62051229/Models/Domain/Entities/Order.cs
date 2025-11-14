using System;
using System.Collections.Generic;
using System.Linq;

namespace Examen1_BrayanAguilar_62051229.Models.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Guid FoodTruckId { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();
        public OrderStatus Estado { get; private set; }
        public decimal Total { get; private set; }
        public DateTime CreadaEn { get; private set; }

        public Order(Guid id, Guid foodTruckId)
        {
            Id = id;
            FoodTruckId = foodTruckId;
            Estado = OrderStatus.Creada;
            CreadaEn = DateTime.UtcNow;
        }

        public void AgregarItem(OrderItem item)
        {
            Items.Add(item);
            RecalcularTotal();
        }

        private void RecalcularTotal()
        {
            Total = Items.Sum(i => i.Subtotal);
        }

        public void CambiarEstado(OrderStatus nuevoEstado)
        {
            Estado = nuevoEstado;
        }
    }
}
