using Microsoft.EntityFrameworkCore;
using ManejoTareas.Entidades;

namespace ManejoTareas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }


    }
}