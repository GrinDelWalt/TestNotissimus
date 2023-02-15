using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class BookRepository : IBaseRepository<Book>
    {
        public Task<bool> Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
