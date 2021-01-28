using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Domain
{
    public class Livro
    {
        public Livro()
        {
            this.Autores = new List<Autor>();
        }

        public int Id { get; set; }

        public string Titulo { get; set; } //nome

        public string ISBN { get; set; }

        public DateTime DataLancamento { get; set; }

        public int CategoriaId { get; set; } //o EF consegue mapear esta referência
        public Categoria Categoria { get; set; } // instância do obj que contém os dados da categoria
        
        public ICollection<Autor> Autores { get; set; }
    }
}