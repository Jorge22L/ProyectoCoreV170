using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class CursosOnlineContext:DbContext
    {
        public CursosOnlineContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new {ci.InstructorId, ci.CursoId});
        }

        public DbSet<Comentario> tblComentario { get; set; }
        public DbSet<Curso> tblCurso { get; set; }
        public DbSet<CursoInstructor> tblCursoInstructor { get; set; }
        public DbSet<Instructor> tblInstructor { get; set; }
        public DbSet<Precio> tblPrecio { get; set; }
    }
}
