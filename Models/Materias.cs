using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("titulo")]
        [Display(Name = "Titulo da materia")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("ProfessoresId")]
        [Display(Name = "Professores")]
        public int ProfessoresId { get; set; }
        public Professores? Professores { get; set; }


    }
}