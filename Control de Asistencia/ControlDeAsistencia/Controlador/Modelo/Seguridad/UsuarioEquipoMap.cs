using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class UsuarioEquipoMap :EntityTypeConfiguration<EUsuarioEquipo>
    {
        public UsuarioEquipoMap()
        {
            ToTable("Seguridad.UsuarioEquipo");

            Property(x => x.Id)
                .HasColumnName("UsuarioEquipoId");

            HasKey(x => x.Id);

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.UsuarioId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Equipo)
                .WithMany()
                .HasForeignKey(x => x.EquipoId)
                .WillCascadeOnDelete();


        }
    }
}
