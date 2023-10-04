using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetOrigins.EFCore;

[Table("order")]
public class Order
{
    [Key, Required] 
    public int id { get; set; }
    
    public int product_id { get; set; }
    
    public virtual Product Product { get; set; }
    
    public int size { get; set; }
    
    public decimal price { get; set; }
}