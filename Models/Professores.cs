﻿using SGE.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Professores")]
    public class Professores
    {
        [Column("Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Seu Telefone")]
        public string Telefone { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "Seu Cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; } = string.Empty;
    }
}