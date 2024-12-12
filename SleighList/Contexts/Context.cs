using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SleighList.Models;

namespace SleighList.Contexts
{
    // Classe que terá as informações do banco de dados
    public class Context : DbContext
    {
        // Criar um método construtor
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // OnConfiguring -> Possui a configuracao da conexao com
        //o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // colocar as informacoes do banco
            // As configuracoes existem?
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=NOTE12-S28\\SQLEXPRESS; Initial Catalog = SleighList; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");

            }

        }
        public DbSet<Usuario> Usuario { get; set; }
        // Curso
        public DbSet<Item> Item { get; set; }

        // As referencias das nossas tabelas no banco de dados:

    }
}