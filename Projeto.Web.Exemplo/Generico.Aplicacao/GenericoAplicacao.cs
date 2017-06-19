using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generico.Repositorio;
using Generico.Dominio;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Generico.Aplicacao
{
    public class GenericoAplicacao : DbContext
    {
        public DbSet<TB_GENERO> genero { get; set; }
        public DbSet<TB_LIVRO> livro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(200));
        }
    }
}
