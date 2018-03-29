using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class EquipoMap : EntityTypeConfiguration<EEquipo>
    {
        public EquipoMap()
        {
            ToTable("Seguridad.Equipos");

            Property(x => x.Id)
                .HasColumnName("EquipoId");

            HasKey(x => x.Id);

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.NumeroIp)
                .HasColumnName("NumeroIP")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
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
