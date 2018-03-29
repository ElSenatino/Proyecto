namespace Controlador.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Asistencia.Asistencias",
                c => new
                    {
                        AsistenciaId = c.Guid(nullable: false),
                        Mes = c.Int(nullable: false),
                        Año = c.Int(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Ingreso = c.DateTime(nullable: false),
                        InicioAlmuerzo = c.DateTime(),
                        FinalAlmuerzo = c.DateTime(),
                        Salida = c.DateTime(),
                    })
                .PrimaryKey(t => t.AsistenciaId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Comun.Personas",
                c => new
                    {
                        PersonaId = c.Guid(nullable: false),
                        NombreGenerado = c.String(nullable: false, maxLength: 200, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellidos = c.String(nullable: false, maxLength: 100, unicode: false),
                        TipoDocumento = c.Int(nullable: false),
                        NroDocumento = c.String(nullable: false, maxLength: 15, unicode: false),
                        TipoSexo = c.Int(nullable: false),
                        Nacimiento = c.DateTime(nullable: false),
                        Imagen = c.Binary(storeType: "image"),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                        Usuario_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.PersonaId)
                .ForeignKey("Seguridad.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "Comun.CargoPersonas",
                c => new
                    {
                        CargoPersonaId = c.Guid(nullable: false),
                        CargoId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        DepartamentoId = c.Guid(nullable: false),
                        JornadaId = c.Guid(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CargoPersonaId)
                .ForeignKey("Comun.Cargos", t => t.CargoId, cascadeDelete: true)
                .ForeignKey("Comun.Departamentos", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("Asistencia.Jornadas", t => t.JornadaId, cascadeDelete: true)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.CargoId)
                .Index(t => t.PersonaId)
                .Index(t => t.DepartamentoId)
                .Index(t => t.JornadaId);
            
            CreateTable(
                "Comun.Cargos",
                c => new
                    {
                        CargoId = c.Guid(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CargoId);
            
            CreateTable(
                "Comun.Departamentos",
                c => new
                    {
                        DepartamentoId = c.Guid(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            CreateTable(
                "Asistencia.Jornadas",
                c => new
                    {
                        JornadaId = c.Guid(nullable: false),
                        TipoJornada = c.Int(nullable: false),
                        Descripcion = c.String(maxLength: 200, unicode: false),
                        Ingreso = c.String(nullable: false, maxLength: 15, unicode: false),
                        Salida = c.String(nullable: false, maxLength: 15, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.JornadaId);
            
            CreateTable(
                "Asistencia.ControlPersonales",
                c => new
                    {
                        ControlPersonaId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Desde = c.DateTime(nullable: false),
                        Hasta = c.DateTime(nullable: false),
                        DiasAsistidos = c.Int(nullable: false),
                        DiasFaltados = c.Int(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ControlPersonaId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Comun.Correos",
                c => new
                    {
                        CorreoId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        CorreoElectronico = c.String(nullable: false, maxLength: 200, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CorreoId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Comun.Direcciones",
                c => new
                    {
                        DireccionId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        TipoDireccion = c.Int(nullable: false),
                        NombreVia = c.String(nullable: false, maxLength: 15, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 15, unicode: false),
                        Urbanizacion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Referencia = c.String(maxLength: 100, unicode: false),
                        UbigeoId = c.Guid(nullable: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DireccionId)
                .ForeignKey("Comun.Ubigeos", t => t.UbigeoId, cascadeDelete: true)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId)
                .Index(t => t.UbigeoId);
            
            CreateTable(
                "Comun.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Codigo = c.String(nullable: false, maxLength: 15, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, unicode: false),
                        Departamento = c.String(),
                        Provincia = c.String(nullable: false, maxLength: 50, unicode: false),
                        Distrito = c.String(nullable: false, maxLength: 100, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UbigeoId);
            
            CreateTable(
                "Asistencia.Justificaciones",
                c => new
                    {
                        JustificacionId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Desde = c.DateTime(nullable: false),
                        Hasta = c.DateTime(nullable: false),
                        Detalle = c.String(nullable: false, maxLength: 200, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.JustificacionId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Asistencia.Permisos",
                c => new
                    {
                        PermisoId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Desde = c.DateTime(nullable: false),
                        Hasta = c.DateTime(nullable: false),
                        Detalle = c.String(nullable: false, maxLength: 200, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PermisoId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Asistencia.Sanciones",
                c => new
                    {
                        SancionId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 200, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SancionId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Comun.Telefonos",
                c => new
                    {
                        TelefonoId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        TipoTelefono = c.Int(nullable: false),
                        NroTelefono = c.Int(nullable: false),
                        Observacion = c.String(maxLength: 100, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TelefonoId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Seguridad.Usuarios",
                c => new
                    {
                        UsuarioId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Clave = c.String(nullable: false, maxLength: 20, unicode: false),
                        CambiaContraseña = c.Boolean(nullable: false),
                        UltimaOperacion = c.DateTime(nullable: false),
                        EnLinea = c.Boolean(nullable: false),
                        Administrador = c.Boolean(nullable: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "Seguridad.RolUsuarios",
                c => new
                    {
                        RolUsuarioId = c.Guid(nullable: false),
                        UsuarioId = c.Guid(nullable: false),
                        RolId = c.Guid(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RolUsuarioId)
                .ForeignKey("Seguridad.Roles", t => t.RolId, cascadeDelete: true)
                .ForeignKey("Seguridad.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.RolId);
            
            CreateTable(
                "Seguridad.Roles",
                c => new
                    {
                        RolId = c.Guid(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "Seguridad.UsuarioEquipo",
                c => new
                    {
                        UsuarioEquipoId = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        UsuarioId = c.Guid(nullable: false),
                        EquipoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioEquipoId)
                .ForeignKey("Seguridad.Equipos", t => t.EquipoId, cascadeDelete: true)
                .ForeignKey("Seguridad.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.EquipoId);
            
            CreateTable(
                "Seguridad.Equipos",
                c => new
                    {
                        EquipoId = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        NumeroIP = c.String(nullable: false, maxLength: 20, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EquipoId);
            
            CreateTable(
                "Seguridad.Sesiones",
                c => new
                    {
                        SesionId = c.Guid(nullable: false),
                        UsuarioEquipoId = c.Guid(nullable: false),
                        Inicio = c.DateTime(nullable: false),
                        Final = c.DateTime(nullable: false),
                        Habilitado = c.Boolean(),
                        TipoEntrada = c.Int(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SesionId)
                .ForeignKey("Seguridad.UsuarioEquipo", t => t.UsuarioEquipoId, cascadeDelete: true)
                .Index(t => t.UsuarioEquipoId);
            
            CreateTable(
                "Segiridad.Auditorias",
                c => new
                    {
                        AuditoriaId = c.Guid(nullable: false),
                        SesionId = c.Guid(nullable: false),
                        EntidadId = c.Guid(nullable: false),
                        Registro = c.DateTime(nullable: false),
                        Metodo = c.String(nullable: false, maxLength: 25, unicode: false),
                        CodigoRegistro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuditoriaId)
                .ForeignKey("Seguridad.Entidades", t => t.EntidadId, cascadeDelete: true)
                .ForeignKey("Seguridad.Sesiones", t => t.SesionId, cascadeDelete: true)
                .Index(t => t.SesionId)
                .Index(t => t.EntidadId);
            
            CreateTable(
                "Seguridad.Entidades",
                c => new
                    {
                        EntidadId = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        NombreMostrado = c.String(nullable: false, maxLength: 100, unicode: false),
                        NombreMostradoPlural = c.String(nullable: false, maxLength: 100, unicode: false),
                        ModuloId = c.Guid(nullable: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntidadId)
                .ForeignKey("Seguridad.Modulos", t => t.ModuloId, cascadeDelete: true)
                .Index(t => t.ModuloId);
            
            CreateTable(
                "Seguridad.Modulos",
                c => new
                    {
                        ModuloId = c.Guid(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 20, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ModuloId);
            
            CreateTable(
                "Seguridad.ReporteModulos",
                c => new
                    {
                        ReporteModuloId = c.Guid(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        ReporteId = c.Guid(nullable: false),
                        ModuloId = c.Guid(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReporteModuloId)
                .ForeignKey("Seguridad.Reportes", t => t.ReporteId, cascadeDelete: true)
                .ForeignKey("Seguridad.Modulos", t => t.ModuloId, cascadeDelete: true)
                .Index(t => t.ReporteId)
                .Index(t => t.ModuloId);
            
            CreateTable(
                "Seguridad.Reportes",
                c => new
                    {
                        ReporteId = c.Guid(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false),
                        ReportServer = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ruta = c.String(nullable: false, maxLength: 100, unicode: false),
                        Habilitado = c.Boolean(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReporteId);
            
            CreateTable(
                "Seguridad.UsuarioModulos",
                c => new
                    {
                        UsuarioModuloId = c.Guid(nullable: false),
                        UsuarioId = c.Guid(nullable: false),
                        ModuloId = c.Guid(nullable: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioModuloId)
                .ForeignKey("Seguridad.Modulos", t => t.ModuloId, cascadeDelete: true)
                .ForeignKey("Seguridad.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.ModuloId);
            
            CreateTable(
                "Asistencia.Vacaciones",
                c => new
                    {
                        VacacionId = c.Guid(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                        Inicio = c.DateTime(nullable: false),
                        Final = c.DateTime(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 200, unicode: false),
                        Actualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VacacionId)
                .ForeignKey("Comun.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Asistencia.Vacaciones", "PersonaId", "Comun.Personas");
            DropForeignKey("Comun.Personas", "Usuario_Id", "Seguridad.Usuarios");
            DropForeignKey("Seguridad.UsuarioModulos", "UsuarioId", "Seguridad.Usuarios");
            DropForeignKey("Seguridad.UsuarioEquipo", "UsuarioId", "Seguridad.Usuarios");
            DropForeignKey("Seguridad.Sesiones", "UsuarioEquipoId", "Seguridad.UsuarioEquipo");
            DropForeignKey("Segiridad.Auditorias", "SesionId", "Seguridad.Sesiones");
            DropForeignKey("Seguridad.UsuarioModulos", "ModuloId", "Seguridad.Modulos");
            DropForeignKey("Seguridad.ReporteModulos", "ModuloId", "Seguridad.Modulos");
            DropForeignKey("Seguridad.ReporteModulos", "ReporteId", "Seguridad.Reportes");
            DropForeignKey("Seguridad.Entidades", "ModuloId", "Seguridad.Modulos");
            DropForeignKey("Segiridad.Auditorias", "EntidadId", "Seguridad.Entidades");
            DropForeignKey("Seguridad.UsuarioEquipo", "EquipoId", "Seguridad.Equipos");
            DropForeignKey("Seguridad.RolUsuarios", "UsuarioId", "Seguridad.Usuarios");
            DropForeignKey("Seguridad.RolUsuarios", "RolId", "Seguridad.Roles");
            DropForeignKey("Seguridad.Usuarios", "PersonaId", "Comun.Personas");
            DropForeignKey("Comun.Telefonos", "PersonaId", "Comun.Personas");
            DropForeignKey("Asistencia.Sanciones", "PersonaId", "Comun.Personas");
            DropForeignKey("Asistencia.Permisos", "PersonaId", "Comun.Personas");
            DropForeignKey("Asistencia.Justificaciones", "PersonaId", "Comun.Personas");
            DropForeignKey("Comun.Direcciones", "PersonaId", "Comun.Personas");
            DropForeignKey("Comun.Direcciones", "UbigeoId", "Comun.Ubigeos");
            DropForeignKey("Comun.Correos", "PersonaId", "Comun.Personas");
            DropForeignKey("Asistencia.ControlPersonales", "PersonaId", "Comun.Personas");
            DropForeignKey("Comun.CargoPersonas", "PersonaId", "Comun.Personas");
            DropForeignKey("Comun.CargoPersonas", "JornadaId", "Asistencia.Jornadas");
            DropForeignKey("Comun.CargoPersonas", "DepartamentoId", "Comun.Departamentos");
            DropForeignKey("Comun.CargoPersonas", "CargoId", "Comun.Cargos");
            DropForeignKey("Asistencia.Asistencias", "PersonaId", "Comun.Personas");
            DropIndex("Asistencia.Vacaciones", new[] { "PersonaId" });
            DropIndex("Seguridad.UsuarioModulos", new[] { "ModuloId" });
            DropIndex("Seguridad.UsuarioModulos", new[] { "UsuarioId" });
            DropIndex("Seguridad.ReporteModulos", new[] { "ModuloId" });
            DropIndex("Seguridad.ReporteModulos", new[] { "ReporteId" });
            DropIndex("Seguridad.Entidades", new[] { "ModuloId" });
            DropIndex("Segiridad.Auditorias", new[] { "EntidadId" });
            DropIndex("Segiridad.Auditorias", new[] { "SesionId" });
            DropIndex("Seguridad.Sesiones", new[] { "UsuarioEquipoId" });
            DropIndex("Seguridad.UsuarioEquipo", new[] { "EquipoId" });
            DropIndex("Seguridad.UsuarioEquipo", new[] { "UsuarioId" });
            DropIndex("Seguridad.RolUsuarios", new[] { "RolId" });
            DropIndex("Seguridad.RolUsuarios", new[] { "UsuarioId" });
            DropIndex("Seguridad.Usuarios", new[] { "PersonaId" });
            DropIndex("Comun.Telefonos", new[] { "PersonaId" });
            DropIndex("Asistencia.Sanciones", new[] { "PersonaId" });
            DropIndex("Asistencia.Permisos", new[] { "PersonaId" });
            DropIndex("Asistencia.Justificaciones", new[] { "PersonaId" });
            DropIndex("Comun.Direcciones", new[] { "UbigeoId" });
            DropIndex("Comun.Direcciones", new[] { "PersonaId" });
            DropIndex("Comun.Correos", new[] { "PersonaId" });
            DropIndex("Asistencia.ControlPersonales", new[] { "PersonaId" });
            DropIndex("Comun.CargoPersonas", new[] { "JornadaId" });
            DropIndex("Comun.CargoPersonas", new[] { "DepartamentoId" });
            DropIndex("Comun.CargoPersonas", new[] { "PersonaId" });
            DropIndex("Comun.CargoPersonas", new[] { "CargoId" });
            DropIndex("Comun.Personas", new[] { "Usuario_Id" });
            DropIndex("Asistencia.Asistencias", new[] { "PersonaId" });
            DropTable("Asistencia.Vacaciones");
            DropTable("Seguridad.UsuarioModulos");
            DropTable("Seguridad.Reportes");
            DropTable("Seguridad.ReporteModulos");
            DropTable("Seguridad.Modulos");
            DropTable("Seguridad.Entidades");
            DropTable("Segiridad.Auditorias");
            DropTable("Seguridad.Sesiones");
            DropTable("Seguridad.Equipos");
            DropTable("Seguridad.UsuarioEquipo");
            DropTable("Seguridad.Roles");
            DropTable("Seguridad.RolUsuarios");
            DropTable("Seguridad.Usuarios");
            DropTable("Comun.Telefonos");
            DropTable("Asistencia.Sanciones");
            DropTable("Asistencia.Permisos");
            DropTable("Asistencia.Justificaciones");
            DropTable("Comun.Ubigeos");
            DropTable("Comun.Direcciones");
            DropTable("Comun.Correos");
            DropTable("Asistencia.ControlPersonales");
            DropTable("Asistencia.Jornadas");
            DropTable("Comun.Departamentos");
            DropTable("Comun.Cargos");
            DropTable("Comun.CargoPersonas");
            DropTable("Comun.Personas");
            DropTable("Asistencia.Asistencias");
        }
    }
}
