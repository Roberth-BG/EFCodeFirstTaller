using EFCodeFirstTaller.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstTaller.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; } = null!;
    public DbSet<Paciente> Pacientes { get; set; } = null!;
}