using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class CorreoMap : EntityTypeConfiguration<ECorreo>
    {

        public CorreoMap()
        {
            ToTable("Comun.Correos");

            Property(x => x.Id)
                 .HasColumnName("CorreoId");                 

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.CorreoElectronico)
                .HasColumnName("CorreoElectronico")
                .HasColumnType("Varchar")
                .HasMaxLength(200)
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
