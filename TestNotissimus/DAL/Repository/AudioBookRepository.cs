using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class AudioBookRepository : IBaseRepository<AudioBook>
    {
        public Task<bool> Create(AudioBook entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(AudioBook entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AudioBook> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AudioBook> Update(AudioBook entity)
        {
            throw new NotImplementedException();
        }
    }
}
