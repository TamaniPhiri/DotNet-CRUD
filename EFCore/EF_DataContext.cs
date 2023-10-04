using Microsoft.EntityFrameworkCore;

namespace dotNetOrigins.EFCore;

public class EF_DataContext
{
    public EF_DataContext(DbContextOptions<EF_DataContext> options):base(options)
    {
        
    }
}