using System;
using Entidad.Seguridad;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class EntidadMap :EntityTypeConfiguration<Entidad.Seguridad.EEntidad>
    {
        public EntidadMap()
        {
            ToTable("Seguridad.Entidades");


            Property(x => x.Id)
                .HasColumnName("EntidadId");


            HasKey(x => x.Id);

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();


            Property(x => x.NombreMostrado)
                .HasColumnName("NombreMostrado")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();


            Property(x => x.NombreMostradoPlural)
                .HasColumnName("NombreMostradoPlural")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            HasRequired(x => x.Modulo)
                .WithMany()
                .HasForeignKey(x => x.ModuloId)
                .WillCascadeOnDelete();

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
