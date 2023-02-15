using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class MusicRepository : IBaseRepository<Music>
    {
        public Task<bool> Create(Music entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Music entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Music> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Music> Update(Music entity)
        {
            throw new NotImplementedException();
        }
    }
}
