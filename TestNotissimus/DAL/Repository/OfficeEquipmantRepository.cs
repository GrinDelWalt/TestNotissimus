using TestNotissimus.DAL.Interfece;
using TestNotissimus.Models;

namespace TestNotissimus.DAL.Repository
{
    public class OfficeEquipmantRepository : IBaseRepository<OfficeEquipment>
    {
        public Task<bool> Create(OfficeEquipment entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(OfficeEquipment entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OfficeEquipment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OfficeEquipment> Update(OfficeEquipment entity)
        {
            throw new NotImplementedException();
        }
    }
}
