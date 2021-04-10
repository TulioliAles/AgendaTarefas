using Microsoft.EntityFrameworkCore;

namespace AgendaTarefa.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes):base(opcoes)
        {

        }
    }
}
