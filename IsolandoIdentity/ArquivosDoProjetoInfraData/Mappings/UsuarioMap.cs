using System.Data.Entity.ModelConfiguration;
using Mau.PauloMau.Domain.Entities;

namespace Mau.PauloMau.Infra.Data.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            ToTable("AspNetUsers");
        }
    }
}