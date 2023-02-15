using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class ProductRepository : IBaseRepository<Products>
    {
        public Task<bool> Create(Products entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Products entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Products> Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
