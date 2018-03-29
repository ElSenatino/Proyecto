using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Asistencia
{
    public class SancionMap :EntityTypeConfiguration<ESanciones>
    {

        public SancionMap()
        {
            ToTable("Asistencia.Sanciones");

            Property(x => x.Id)
                .HasColumnName("SancionId");

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.Descripcion)
                .HasColumnName("Descripcion")
                .HasColumnType("Varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();
                
        }

    }
}
