using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Titulo da materia")]
        public string Titulo { get; set; } = string.Empty;

        [Column("Ano")]
        [Display(Name = "Ano")]
        public string Ano { get; set; } = string.Empty;




    }
}