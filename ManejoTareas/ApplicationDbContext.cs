using Microsoft.EntityFrameworkCore;
using ManejoTareas.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ManejoTareas
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }


    }
}