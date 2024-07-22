using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerce.Models.DTOs;

public class CartItemAddDTO {
    [Required]
    public int CartId { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public int Quantity { get; set; }
}