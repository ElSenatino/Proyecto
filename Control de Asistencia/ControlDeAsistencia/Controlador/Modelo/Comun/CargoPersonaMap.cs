using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class CargoPersonaMap :EntityTypeConfiguration<ECargoPersona>
    {
        public CargoPersonaMap()
        {
            ToTable("Comun.CargoPersonas");

            Property(x => x.Id)
                .HasColumnName("CargoPersonaId");

            HasKey(x => x.Id);

            HasRequired(x => x.Cargo)
                .WithMany()
                .HasForeignKey(x => x.CargoId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Departamento)
                .WithMany()
                .HasForeignKey(x => x.DepartamentoId)
                .WillCascadeOnDelete();

            HasRequired(x => x.Jornada)
                .WithMany()
                .HasForeignKey(x => x.JornadaId)
                .WillCascadeOnDelete();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();

        }

    }
}
