using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Models;

public class ReviewModel
{
    public Guid ReviewId { get; set; }

    [Required(ErrorMessage = "Comment text is required")]
    [MinLength(5, ErrorMessage = "Comment text should be at least 5 letter")]
    public string? Comment { get; set; }

    //Foreign Key
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }

    //Navigation properties
    // public List<ProductModel>? Products { get; set; }
    public UserModel? User { get; set; }
}
