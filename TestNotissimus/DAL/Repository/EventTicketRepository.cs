using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class EventTicketRepository : IBaseRepository<EventTicket>
    {
        public Task<bool> Create(EventTicket entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(EventTicket entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EventTicket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EventTicket> Update(EventTicket entity)
        {
            throw new NotImplementedException();
        }
    }
}
