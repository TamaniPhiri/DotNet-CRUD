using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetOrigins.EFCore;

[Table("product")]
public class Product
{
    public int id { get; set; }
}