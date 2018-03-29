using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Asistencia
{
    public class JornadaMap:EntityTypeConfiguration<EJornada>
    {
        public JornadaMap()
        {
            ToTable("Asistencia.Jornadas");

            Property(x => x.Id)
                .HasColumnName("JornadaId");

            HasKey(x => x.Id);

            Property(x => x.TipoJornada)
                .HasColumnName("TipoJornada")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.Descripcion)
                .HasColumnName("Descripcion")
                .HasColumnType("Varchar")
                .HasMaxLength(200)
                .IsOptional();

            Property(x => x.Ingreso)
                .HasColumnName("Ingreso")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.Salida)
                .HasColumnName("Salida")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();



        }
    }
}
