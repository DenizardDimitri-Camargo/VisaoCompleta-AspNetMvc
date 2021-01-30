using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable //força ter um método Dispose quando for destruir a conexão com BD
    {
        List<Autor> Get();
        Autor Get(int id);
        List<Autor> GetByName(string name);
        bool Create(Autor autor); //poderia ser void
        bool Update(Autor autor); //poderia ser void
        void Delete(int id);
    }
}