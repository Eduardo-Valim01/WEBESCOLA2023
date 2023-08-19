using Microsoft.EntityFrameworkCore;

namespace WEBESCOLA.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Sala> Salas { get; set; }

    }
}
