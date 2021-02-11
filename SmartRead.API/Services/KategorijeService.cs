using AutoMapper;
using SmartRead.API.Database.Context;
using SmartRead.Model;
using System.Collections.Generic;
using System.Linq;

namespace SmartRead.API.Services
{
    public class KategorijeService: IKategorijeService
    {
        private SmartReadContext _context;
        private IMapper _mapper;
        public KategorijeService(SmartReadContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<Kategorija> Get(Model.Requests.KategorijaInsertRequest request)
        {
            var query = _context.Kategorije.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(request.Naziv));
            }

            query = query.Where(x => x.Obrisan == request.Obrisan);

            var list = query.ToList();

            return _mapper.Map<List<Model.Kategorija>>(list);
        }

        public Kategorija Insert(string naziv)
        {
            var kategorija = new Database.Kategorija
            {
                Naziv = naziv,
                Obrisan = false
            };

            _context.Kategorije.Add(kategorija);
            _context.SaveChanges();

            return _mapper.Map<Model.Kategorija>(kategorija);
        }

        public Kategorija Update(int id, Model.Requests.KategorijaInsertRequest request)
        {
            var kategorija = _context.Kategorije.Find(id);
            if (kategorija == null)
            {
                return null;
            }
            _mapper.Map(request, kategorija);
            _context.SaveChanges();

            return _mapper.Map<Model.Kategorija>(kategorija);
        }

        public bool Delete(int id)
        {
            var kategorija = _context.Kategorije.Find(id);
            if (kategorija == null)
            {
                return false;
            }

            kategorija.Obrisan = true;
            _context.SaveChanges();

            return true;
        }
    }
}
