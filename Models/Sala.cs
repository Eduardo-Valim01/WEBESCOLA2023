using System.ComponentModel.DataAnnotations;

namespace WEBESCOLA.Models
{
    public class Sala
    {
        [Key]
        public int id { get; set; }
        
        [StringLength(20)]
        public string descricao { get; set; }
        public int equipamento { get; set; }
        public char situacao { get; set; }

    }
}
