using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRead.API.Services
{
    public interface IKategorijeService
    {
        List<Model.Kategorija> Get(Model.Requests.KategorijaInsertRequest request);
        Model.Kategorija Insert(string naziv);
        Model.Kategorija Update(int id, Model.Requests.KategorijaInsertRequest request);
        bool Delete(int id);
    }
}
