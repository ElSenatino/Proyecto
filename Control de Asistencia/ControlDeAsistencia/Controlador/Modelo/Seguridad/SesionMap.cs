using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class SesionMap :EntityTypeConfiguration<ESesion>
    {
        public SesionMap()
        {
            ToTable("Seguridad.Sesiones");

            Property(x => x.Id)
                .HasColumnName("SesionId");

            HasKey(x => x.Id);

            HasRequired(x => x.UsuarioEquipo)
                .WithMany()
                .HasForeignKey(x => x.UsuarioEquipoId)
                .WillCascadeOnDelete();


            Property(x => x.Inicio)
                .HasColumnName("Inicio")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.Final)
                .HasColumnName("Final")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.Habilitado)
                .HasColumnName("Habilitado")
                .HasColumnType("Bit")
                .IsOptional();

            Property(x => x.TipoEntrada)
               .HasColumnName("TipoEntrada")
               .HasColumnType("Int")
               .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();

        }
    }
}
