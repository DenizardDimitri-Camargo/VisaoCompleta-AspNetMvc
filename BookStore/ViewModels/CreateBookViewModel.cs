using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class CreateBookViewModel
    {

        [Required(ErrorMessage = "* Título Obrigatório")]
        [Display(Name = "Nome do Livro")]
        public string Titulo { get; set; } //nome

        [Required(ErrorMessage = "* ISBN Obrigatório")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "* Data de Lançamento Obrigatória")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        
        [Required(ErrorMessage = "* Categoria Obrigatória")]
        [Display(Name = "Nome do Livro")]
        public int CategoriaId { get; set; } //não foi exibido na view, creio que seja só para relacionamento

        public SelectList Categoriaoptions { get; set; }
    }
}