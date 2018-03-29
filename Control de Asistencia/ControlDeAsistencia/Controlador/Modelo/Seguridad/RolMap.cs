using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class RolMap : EntityTypeConfiguration<ERol>
    {

        public RolMap()
        {
            ToTable("Seguridad.Roles");


            Property(x => x.Id)
                .HasColumnName("RolId");

            HasKey(x => x.Id);

            Property(x => x.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Descripcion)
                .HasColumnName("Descripcion")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Habilitado)
               .HasColumnName("Habilitado")
               .HasColumnType("Bit")
               .IsRequired();

            Property(x => x.Actualizacion)
               .HasColumnName("Actualizacion")
               .HasColumnType("DateTime")
               .IsRequired();

        }

    }
}
