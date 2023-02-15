using Microsoft.AspNetCore.Http;
using TestNotissimus.Enam;

namespace TestNotissimus.Interfeces
{
    public interface IBaseResponse<T>
    {
        T Data { get; set; }
        StatusCode StatusCode { get; set; }
        string Description { get; set; }
    }
}
