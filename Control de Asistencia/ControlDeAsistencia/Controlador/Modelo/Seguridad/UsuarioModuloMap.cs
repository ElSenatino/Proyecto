using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class UsuarioModuloMap :EntityTypeConfiguration<EUsuarioModulo>
    {

        public UsuarioModuloMap()
        {
            ToTable("Seguridad.UsuarioModulos");

            Property(x => x.Id)
                .HasColumnName("UsuarioModuloId");



            HasRequired(x => x.Modulo)
                .WithMany()
                .HasForeignKey(x => x.ModuloId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.UsuarioId)
                .WillCascadeOnDelete();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();

        }
    }
}
