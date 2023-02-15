using TestNotissimus.Models;

namespace TestNotissimus.Service.Interfeces
{
    public interface IProductsService
    {
        Task<IBaseResponse<IEnumerable<Products>>> GetAllCars();
        
    }
}
