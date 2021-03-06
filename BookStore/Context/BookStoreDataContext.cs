﻿using BookStore.Domain;
using BookStore.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Context
{
    public class BookStoreDataContext : DbContext
    {
        public BookStoreDataContext()
            : base("BookStoreConnectionString")
        {

        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // informa ao context que tenho as classes no Maping
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());
        }
    }
}