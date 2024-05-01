using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ecommerce.EnitiyFramework;

[Table("review")]
public class Review
{
    [Key, Required]
    [Column("review_id")]
    public Guid ReviewId { get; set; }

    [Required]
    [MinLength(5)]
    [Column("comment")]
    public string? Comment { get; set; }

    //Foreign Key
    [Column("product_id")]
    public Guid ProductId { get; set; }

    [Column("user_id")]
    public Guid UserId { get; set; }

    //Navigation properties
    // public List<ProductModel>? Products { get; set; }
    [ForeignKey("UserId")]
    public User? User { get; set; }
}
