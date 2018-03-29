using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class ModuloMap : EntityTypeConfiguration<EModulo>
    {
        public ModuloMap()
        {
            ToTable("Seguridad.Modulos");

            Property(x => x.Id)
                .HasColumnName("ModuloId");

            HasKey(x => x.Id);

            Property(x => x.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.Descripcion)
               .HasColumnName("Descripcion")
               .HasColumnType("Varchar")
               .HasMaxLength(100)
               .IsRequired();

            Property(x => x.Habilitado)
              .HasColumnName("Habilitado")
              .HasColumnType("bit")
              .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();
        }
    }
}
