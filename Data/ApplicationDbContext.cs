using Microsoft.EntityFrameworkCore;
using MyTE.Models;

namespace MyTE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Wbs> Wbs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Horas> Horas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>().ToTable("TB_Departamento");
            modelBuilder.Entity<Usuario>().ToTable("TB_Usuario");
            modelBuilder.Entity<Wbs>().ToTable("TB_Wbs");
            modelBuilder.Entity<Login>().ToTable("TB_Login");
            modelBuilder.Entity<Horas>().ToTable("TB_Horas");

        }
    }
}
