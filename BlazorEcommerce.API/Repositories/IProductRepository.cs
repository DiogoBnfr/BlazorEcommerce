using BlazorEcommerce.API.Entities;

namespace BlazorEcommerce.API.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetItems();
    Task<Product> GetItem(int id);
    Task<IEnumerable<Product>> GetItemsByCategory(int id);
}