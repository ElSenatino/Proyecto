using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Asistencia
{
    public class ControlAsistenciaMap :EntityTypeConfiguration<EControlPersonal>
    {
        public ControlAsistenciaMap()
        {
            ToTable("Asistencia.ControlPersonales");

            Property(x => x.Id)
                .HasColumnName("ControlPersonaId");

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.Desde)
                .HasColumnName("Desde")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.Hasta)
                .HasColumnName("Hasta")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.DiasAsistidos)
                .HasColumnName("DiasAsistidos")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.DiasFaltados)
                .HasColumnName("DiasFaltados")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();


        }

    }
}
