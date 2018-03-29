namespace Controlador.Context
{
    using Controlador.Modelo.Asistencia;
    using Controlador.Modelo.Comun;
    using Controlador.Modelo.Seguridad;
    using Entidad.Comun;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EContext : DbContext
    {
        public EContext()
            : base("EFContext")
           //: base(@"data source=SAMUEL\SA;initial catalog = ControlDeAsistencia; integrated security = false; User Id = sa; Password = 123;")
           
        {
            //var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        ///* Comun*/
        //public DbSet<EPersona> Persona { get; set; }
        //public DbSet<EUbigeo> Ubigeo { get; set; }
        //public DbSet<EContext> Correo { get; set; }
        //public DbSet<EDireccion> Direccion { get; set; }
        //public DbSet<ECargoPersona> CargoPersona { get; set; }
        //public DbSet<ETelefono> Telefono { get; set; }

       


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {



            modelBuilder.Configurations.Add(new AsistenciaMap());
            modelBuilder.Configurations.Add(new ControlAsistenciaMap());
            modelBuilder.Configurations.Add(new JornadaMap());
            modelBuilder.Configurations.Add(new JustificacionMap());
            modelBuilder.Configurations.Add(new PermisoMap());
            modelBuilder.Configurations.Add(new SancionMap());
            modelBuilder.Configurations.Add(new VacacionMap());


            modelBuilder.Configurations.Add(new CargoMap());
            modelBuilder.Configurations.Add(new CargoPersonaMap());
            modelBuilder.Configurations.Add(new CorreoMap());
            modelBuilder.Configurations.Add(new DepartamentoMap());
            modelBuilder.Configurations.Add(new DireccionMap());
            modelBuilder.Configurations.Add(new PersonaMap());
            modelBuilder.Configurations.Add(new TelefonoMap());
            modelBuilder.Configurations.Add(new UbigeoMap());


            modelBuilder.Configurations.Add(new AuditoriaMap());
            modelBuilder.Configurations.Add(new EntidadMap());
            modelBuilder.Configurations.Add(new EquipoMap());
            modelBuilder.Configurations.Add(new ModuloMap());
            modelBuilder.Configurations.Add(new ReporteMap());
            modelBuilder.Configurations.Add(new ReporteModuloMap());
            modelBuilder.Configurations.Add(new RolMap());
            modelBuilder.Configurations.Add(new RolUsuarioMap());
            modelBuilder.Configurations.Add(new SesionMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new UsuarioEquipoMap());

            modelBuilder.Configurations.Add(new UsuarioModuloMap());


            base.OnModelCreating(modelBuilder);
            
         
        }



    }

}