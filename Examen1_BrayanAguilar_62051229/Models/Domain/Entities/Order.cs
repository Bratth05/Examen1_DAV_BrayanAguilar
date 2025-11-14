
namespace Examen1_BrayanAguilar_62051229.Models.Domain.Entities
{
    public class Order
    {
        private Guid guid;
        private Guid foodTruckId;

        public Order(Guid guid, Guid foodTruckId)
        {
            this.guid = guid;
            this.foodTruckId = foodTruckId;
        }

        internal void AgregarItem(OrderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
