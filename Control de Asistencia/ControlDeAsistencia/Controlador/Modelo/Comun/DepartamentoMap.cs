﻿using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Modelo.Comun
{
    public class DepartamentoMap : EntityTypeConfiguration<EDepartamento>
    {
        public DepartamentoMap()
        {
            ToTable("Comun.Departamentos");

            Property(x => x.Id)
                .HasColumnName("DepartamentoId");

            HasKey(x => x.Id);

            Property(x => x.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("Varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("Varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Actualizacion)
                .HasColumnName("Actualizacion")
                .HasColumnType("DateTime")
                .IsRequired();

        }

    }
}