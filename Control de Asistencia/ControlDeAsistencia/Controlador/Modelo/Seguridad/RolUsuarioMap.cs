using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class RolUsuarioMap :EntityTypeConfiguration<ERolUsuario>
    {
        public RolUsuarioMap()
        {
            ToTable("Seguridad.RolUsuarios");

            Property(x => x.Id)
                .HasColumnName("RolUsuarioId");

            HasKey(x => x.Id);


            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x=> x.UsuarioId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Rol)
                .WithMany()
                .HasForeignKey(x => x.RolId)
                .WillCascadeOnDelete();


            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();
        }
    }
}
