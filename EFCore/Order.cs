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
    
    public string name { get; set; }
    
    public string address { get; set; }
    
    public string phone { get; set; }
}