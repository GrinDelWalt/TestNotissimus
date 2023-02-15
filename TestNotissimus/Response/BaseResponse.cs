using TestNotissimus.Enam;
using TestNotissimus.Interfeces;

namespace TestNotissimus.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public T Data { get; set; }
        public StatusCode StatusCode { get; set; }
        public string Description { get; set; }
    }
}
