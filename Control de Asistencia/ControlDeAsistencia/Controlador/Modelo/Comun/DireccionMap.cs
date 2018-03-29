using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class DireccionMap:EntityTypeConfiguration<EDireccion>
    {

        public DireccionMap()
        {
            ToTable("Comun.Direcciones");

            Property(x => x.Id)
                .HasColumnName("DireccionId");

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.TipoDireccion)
                .HasColumnName("TipoDireccion")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.NombreVia)
                .HasColumnName("NombreVia")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.Numero)
                .HasColumnName("Numero")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.Urbanizacion)
                .HasColumnName("Urbanizacion")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Referencia)
                .HasColumnName("Referencia")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsOptional();


            HasRequired(x => x.Ubigeo)
                .WithMany()
                .HasForeignKey(x => x.UbigeoId)
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