using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class ReporteModuloMap : EntityTypeConfiguration<EReporteModulo>
    {

        public ReporteModuloMap()
        {
            ToTable("Seguridad.ReporteModulos");

            Property(x => x.Id)
                .HasColumnName("ReporteModuloId");

            HasKey(x => x.Id);

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            HasRequired(x => x.Reporte)
                .WithMany()
                .HasForeignKey(x => x.ReporteId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Modulo)
                .WithMany()
                .HasForeignKey(x => x.ModuloId)
                .WillCascadeOnDelete();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();



        }
    }
}
