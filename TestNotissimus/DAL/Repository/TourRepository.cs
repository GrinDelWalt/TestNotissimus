using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class TourRepository : IBaseRepository<Tour>
    {
        public Task<bool> Create(Tour entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Tour entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tour> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Tour> Update(Tour entity)
        {
            throw new NotImplementedException();
        }
    }
}
