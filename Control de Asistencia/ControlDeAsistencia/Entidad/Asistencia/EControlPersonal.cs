﻿using Entidad.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.Asistencia
{
    public class EControlPersonal
    {
        public EControlPersonal(){}

        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public Int32 DiasAsistidos { get; set;}
        public Int32 DiasFaltados { get; set;}
        public DateTime Actualizacion { get; set; }

        public virtual EPersona Persona { get; set; }
    }
}
