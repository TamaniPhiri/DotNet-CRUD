using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetOrigins.EFCore;

[Table("product")]
public class Product
{
    [Key,Required]
    public int id { get; set; }
    
    public string name { get; set; }
}