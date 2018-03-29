using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class TelefonoMap:EntityTypeConfiguration<ETelefono>
    {
        public TelefonoMap()
        {
            ToTable("Comun.Telefonos");

            Property(x => x.Id)
                .HasColumnName("TelefonoId");
                

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.TipoTelefono)
                .HasColumnName("TipoTelefono")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.NroTelefono)
                .HasColumnName("NroTelefono")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.Observacion)
                .HasColumnName("Observacion")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsOptional();

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
