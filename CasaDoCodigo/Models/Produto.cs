﻿using System.ComponentModel.DataAnnotations;

namespace CasaDoCodigo.Models
{
    public class Produto : BaseModel
    {
        public Produto() { }

        [Required]
        public Categoria Categoria { get; private set; }
        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal Preco { get; private set; }

        public Produto(string codigo, string nome, decimal preco, Categoria categoria)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
    }
}
