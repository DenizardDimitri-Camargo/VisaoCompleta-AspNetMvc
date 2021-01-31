using BookStore.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class EditorBookViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Título Obrigatório")]
        [Display(Name = "Nome do Livro")]
        public string Titulo { get; set; } //nome

        [Required(ErrorMessage = "* ISBN Obrigatório")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "* Data inválida")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        
        [Required(ErrorMessage = "* Selecione uma categoria")]
        public int CategoriaId { get; set; } //não foi exibido na view, creio que seja só para relacionamento
        public SelectList Categoriaoptions { get; set; }

        [CheckAgeValidator]
        public DateTime Age { get; set; }
    }
}