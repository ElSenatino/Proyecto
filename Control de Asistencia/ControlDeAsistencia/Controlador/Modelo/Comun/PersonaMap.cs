using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class PersonaMap : EntityTypeConfiguration<EPersona>
    {

        public PersonaMap()
        {
            ToTable("Comun.Personas");

            Property(x => x.Id)
                .HasColumnName("PersonaId");
                

            HasKey(x => x.Id);

            Property(x => x.NombreGenerado)
                .HasColumnName("NombreGenerado")
                .HasColumnType("Varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Apellidos)
                .HasColumnName("Apellidos")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.TipoDocumento)
                .HasColumnName("TipoDocumento")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.NroDocumento)
                .HasColumnName("NroDocumento")
                .HasColumnType("Varchar")
                .HasMaxLength(15)
                .IsRequired();

            Property(x => x.TipoSexo)
                .HasColumnName("TipoSexo")
                .HasColumnType("Int")
                .IsRequired();

            Property(x => x.Nacimiento)
                .HasColumnName("Nacimiento")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.Imagen)
                .HasColumnName("Imagen")
                .HasColumnType("Image")
                .IsOptional();

            Property(x => x.Habilitado)
                .HasColumnName("Habilitado")
                .HasColumnType("Bit")
                .IsRequired();

            Property(x => x.Acutalizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();

                

            

        }
    }
}
