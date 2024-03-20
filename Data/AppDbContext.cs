using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CetStudent.Models;

namespace CetStudent.Data;

public partial class ApplicationDbContext : IdentityDbContext
{
    
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Vehicle>? Vehicles { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<CetStudent.Models.Student> Student { get; set; } = default!;
}