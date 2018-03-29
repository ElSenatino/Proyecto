using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class AuditoriaMap:EntityTypeConfiguration<EAuditoria>
    {

        public AuditoriaMap()
        {
            ToTable("Segiridad.Auditorias");

            Property(x => x.Id)
                .HasColumnName("AuditoriaId");

            HasKey(x => x.Id);

            HasRequired(x => x.Sesion)
                .WithMany()
                .HasForeignKey(x => x.SesionId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Entidad)
                .WithMany()
                .HasForeignKey(x => x.EntidadId)
                .WillCascadeOnDelete();

            Property(x => x.Registro)
                .HasColumnName("Registro")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.Metodo)
                .HasColumnName("Metodo")
                .HasColumnType("Varchar")
                .HasMaxLength(25)
                .IsRequired();

            Property(x => x.CodigoRegistro)
                .HasColumnName("CodigoRegistro")
                .HasColumnType("Varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();

        }
    }
}
