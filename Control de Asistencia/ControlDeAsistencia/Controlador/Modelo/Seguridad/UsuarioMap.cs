using Entidad.Seguridad;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Seguridad
{
    public class UsuarioMap :EntityTypeConfiguration<EUsuario>
    
    {

        public UsuarioMap()
        {
            ToTable("Seguridad.Usuarios");


            Property(x => x.Id)
                .HasColumnName("UsuarioId");

            HasKey(x => x.Id);

            HasRequired(x => x.Persona)
                .WithMany()
                .HasForeignKey(x => x.PersonaId)
                .WillCascadeOnDelete();

            Property(x => x.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();


            Property(x => x.Clave)
                .HasColumnName("Clave")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();


            Property(x => x.CambiaContraseña)
                .HasColumnName("CambiaContraseña")
                .HasColumnType("Bit")
                .IsRequired();

            Property(x => x.UltimaOperacion)
                .HasColumnName("UltimaOperacion")
                .HasColumnType("DateTime")
                .IsRequired();

            Property(x => x.EnLinea)
                .HasColumnName("EnLinea")
                .HasColumnType("Bit")
                .IsRequired();


            Property(x => x.Administrador)
                .HasColumnName("Administrador")
                .HasColumnType("Bit")
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
