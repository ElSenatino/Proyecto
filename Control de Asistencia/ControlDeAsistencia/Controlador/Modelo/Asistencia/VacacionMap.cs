using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Asistencia
{
    public class VacacionMap :EntityTypeConfiguration<EVacaciones>
    {

        public VacacionMap()
        {
            ToTable("Asistencia.Vacaciones");

            Property(x => x.Id)
                .HasColumnName("VacacionId");

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.Inicio)
                .HasColumnName("Inicio")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.Final)
                .HasColumnName("Final")
                .HasColumnType("DateTime")
                .IsRequired();


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
