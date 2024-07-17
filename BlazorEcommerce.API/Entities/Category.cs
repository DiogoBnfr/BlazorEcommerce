using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerce.API.Entities;

public class Category
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(200)]
    public string Icon { get; set; } = string.Empty;
    public Collection<Product> Products { get; set; } = [];
}