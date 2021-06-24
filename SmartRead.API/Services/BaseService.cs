using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Database.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IBaseService<TModel, TSearch> where TDatabase : class
    {
        protected readonly SmartReadContext _context;
        protected readonly IMapper _mapper;

        public BaseService(SmartReadContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<List<TModel>> Get(TSearch search)
        {
            var list = await _context.Set<TDatabase>()
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<List<TModel>>(list);
        }

        public virtual async Task<TModel> GetById(int id)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);
            return _mapper.Map<TModel>(entity);
        }

    }
}
