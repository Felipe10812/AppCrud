using AppCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AppCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(tb =>
            {
                // Propiedades de la columna IdEmpleado
                tb.HasKey(col => col.IdEmpleado);
                tb.Property(col => col.IdEmpleado)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                // Propiedades de la columna Nombre
                tb.Property(col => col.Nombre).HasMaxLength(50).IsRequired();

                // Propiedades de la columna Apellido
                tb.Property(col => col.Apellido).HasMaxLength(50).IsRequired();

                // Propiedades de la columna Cargo
                tb.Property(col => col.Cargo).HasMaxLength(50).IsRequired();

                // Propiedades de la columna Direccion
                tb.Property(col => col.Direccion).HasMaxLength(100);

                // Propiedades de la columna Telefono
                tb.Property(col => col.Telefono).IsRequired();

                // Propiedades de la columna Email
                tb.Property(col => col.Email).HasMaxLength(50).IsRequired();

                // Propiedades de la columna Activo
                tb.Property(col => col.Activo).IsRequired();

                // Propiedad de la columna FechaContrato
                tb.Property(col => col.FechaContrato).IsRequired();

                // Proiedad de la columna FechaCreacion
                tb.Property(col => col.FechaCreacion).HasDefaultValueSql("GETDATE()");

            });

            modelBuilder.Entity<Empleado>().ToTable("Empleados");
        }
    }
}