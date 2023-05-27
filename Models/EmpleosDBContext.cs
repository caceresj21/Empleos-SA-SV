using Microsoft.EntityFrameworkCore;
using Empleos_SA_SV.Models;


namespace Empleos_SA_SV.Models
{
    public class EmpleosDBContext : DbContext
    {



        public EmpleosDBContext(DbContextOptions options) : base(options)
        {

        }
            public DbSet<empleos> empleos { get; set; }
            public DbSet<usuarios> usuarios { get; set; }
            public DbSet<publicaciones> publicaciones { get; set; }

            public DbSet<comentarios> comentarios { get; set; }
            public DbSet<ubicacion> ubicacion { get; set; }
           
        }
}
