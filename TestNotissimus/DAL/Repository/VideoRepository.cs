using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class VideoRepository : IBaseRepository<Video>
    {
        public Task<bool> Create(Video entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Video entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Video> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Video> Update(Video entity)
        {
            throw new NotImplementedException();
        }
    }
}
