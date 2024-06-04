using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace WebApiBackend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Modelos a mapear
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Libros> Libro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Insertar en la tabla Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PkUsuario = 1,
                    Nombre = "Carlos",
                    User = "Usuario",
                    Password= "123",
                    FkRol = 1 // Rol correspondientes

                });
            //Insertar en la tabla Roles
            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    PkRol = 1,
                    Nombre = "Sa"
                }
                );     
        }
    }
}