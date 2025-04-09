using Microsoft.EntityFrameworkCore;

namespace WebCRUD_MVC_SQL.Models
{
    public class Contexto : DbContext
    { 
        // criando o construtor do Contexto
        public Contexto(DbContextOptions<Contexto> options) : base(options) 
        { 

        }
        // Definindo quais sao os modelos que devem ser gerenciados pelo migrations
        public DbSet<Produto> Produto { get; set; }
    }
}
