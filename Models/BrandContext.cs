using Microsoft.EntityFrameworkCore;
namespace dotNetOrigins.Models;

public class BrandContext : DbContext{
    public BrandContext(DbContextOptions<BrandContext> options):base(options)
    {
        
    }
}