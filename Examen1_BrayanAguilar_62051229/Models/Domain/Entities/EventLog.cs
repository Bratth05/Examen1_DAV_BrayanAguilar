
namespace Examen1_BrayanAguilar_62051229.Models.Domain.Entities
{
    public class EventLog
    {
        private object id;
        private object estadoAnterior;
        private OrderStatus nuevoEstado;

        public EventLog(object id, object estadoAnterior, OrderStatus nuevoEstado)
        {
            this.id = id;
            this.estadoAnterior = estadoAnterior;
            this.nuevoEstado = nuevoEstado;
        }

        public Guid OrderId { get; internal set; }
    }
}
