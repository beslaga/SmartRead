using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IBaseService<T, TSearch>
    {
        Task<List<T>> Get(TSearch search);
        Task<T> GetById(int id);
    }
}
