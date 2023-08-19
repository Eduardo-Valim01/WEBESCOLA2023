using System.ComponentModel.DataAnnotations;

namespace WEBESCOLA.Models
{
    public class Atendimento
    {
        [Key]
        public int id { get; set; }
        public Aluno aluno { get; set; }
        public Sala sala { get; set; }
        public DateTime dataHora { get; set; }
        
    }
}
