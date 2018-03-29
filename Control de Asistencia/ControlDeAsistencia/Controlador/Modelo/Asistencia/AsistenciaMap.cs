using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Asistencia
{
    public class AsistenciaMap :EntityTypeConfiguration<EAsistencia>
    {
        public AsistenciaMap()
        {
            ToTable("Asistencia.Asistencias");

            Property(x => x.Id)
                .HasColumnName("AsistenciaId");

            HasKey(x => x.Id);

            Property(x => x.Mes)
                .HasColumnName("Mes")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.Año)
                .HasColumnName("Año")
                .HasColumnType("Int")
                .IsRequired();

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.Ingreso)
              .HasColumnName("Ingreso")
              .HasColumnType("DateTime")
              .IsRequired();

            Property(x => x.InicioAlmuerzo)
              .HasColumnName("InicioAlmuerzo")
              .HasColumnType("DateTime")
              .IsOptional();


            Property(x => x.FinalAlmuerzo)
              .HasColumnName("FinalAlmuerzo")
              .HasColumnType("DateTime")
              .IsOptional();

            Property(x => x.Salida)
              .HasColumnName("Salida")
              .HasColumnType("DateTime")
              .IsOptional();


        }
    }
}
