using System.ComponentModel.DataAnnotations;

namespace BlazorEcommerce.API.Entities;

public class User
{
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public Cart? Cart { get; set; }
}