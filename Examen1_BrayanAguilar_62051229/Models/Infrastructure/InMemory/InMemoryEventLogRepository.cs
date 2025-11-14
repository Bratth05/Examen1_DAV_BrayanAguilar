using Examen1_BrayanAguilar_62051229.Models.Domain.Entities;
using Examen1_BrayanAguilar_62051229.Models.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Examen1_BrayanAguilar_62051229.Models.Infrastructure.InMemory
{
    public class InMemoryEventLogRepository : IEventLogRepository
    {
        private readonly List<EventLog> _logs = new();

        public void Add(EventLog log) => _logs.Add(log);

        public IEnumerable<EventLog> GetByOrderId(Guid orderId) =>
            _logs.Where(l => l.OrderId == orderId);
    }
}
