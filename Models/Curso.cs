using System.ComponentModel.DataAnnotations;

namespace WEBESCOLA.Models
{
    public class Curso
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public string descricao { get; set; }

    }
}
