using System.Data.Entity;
using Mau.PauloMau.Domain.Entities;
using Mau.PauloMau.Infra.Data.Mappings;

namespace Mau.PauloMau.Infra.Data.Contexts
{
    public class IdentityEntityContextDb : DbContext
    {
        public IdentityEntityContextDb()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}