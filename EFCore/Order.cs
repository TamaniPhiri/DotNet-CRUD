using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotNetOrigins.EFCore;

[Table("order")]
public class Order
{
    [Key, Required] public int id { get; set; };
}