using Microsoft.EntityFrameworkCore;

namespace dotNetOrigins.EFCore;

public class EF_DataContext:DbContext
{
    public EF_DataContext(DbContextOptions<EF_DataContext> options):base(options)
    {
        
    }

    public override void onModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }

    public DbSet<Order> Orders { get; set; }
}