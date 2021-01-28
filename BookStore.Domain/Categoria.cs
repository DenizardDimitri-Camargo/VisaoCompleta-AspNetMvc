using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Domain
{
    public class Categoria
    {
        public Categoria()
        {
            this.Livros = new List<Livro>();
        }

        public int Id { get; set; }
        
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}