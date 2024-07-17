﻿namespace BlazorEcommerce.Models.DTOs;

public class CartItemDTO
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }

    public string? ProductName { get; set; } = string.Empty;
    public string? ProductDescription { get; set; } = string.Empty;
    public string? ProductImageUrl { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal PriceTotal { get; set; }
}