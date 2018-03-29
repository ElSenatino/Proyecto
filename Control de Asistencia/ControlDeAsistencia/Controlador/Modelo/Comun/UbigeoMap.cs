using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class UbigeoMap:EntityTypeConfiguration<EUbigeo>
    {
        public UbigeoMap()
        {
            ToTable("Comun.Ubigeos");

            Property(x => x.Id)
                .HasColumnName("UbigeoId");

            HasKey(x => x.Id);

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.Pais)
                .HasColumnName("Pais")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.Provincia)
                .HasColumnName("Provincia")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(x => x.Distrito)
                .HasColumnName("Distrito")
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
