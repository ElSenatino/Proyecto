﻿using Entidad.Asistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Asistencia
{
    public class PermisoMap :EntityTypeConfiguration<EPermiso>
    {
        public PermisoMap()
        {
            ToTable("Asistencia.Permisos");

            Property(x => x.Id)
                .HasColumnName("PermisoId");

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

            Property(x => x.Detalle)
                .HasColumnName("Detalle")
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
