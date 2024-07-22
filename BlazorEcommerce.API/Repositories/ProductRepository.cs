using BlazorEcommerce.API.Data;
using BlazorEcommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.API.Repositories;

public class ProductRepository : IProductRepository {
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context) {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetItems() {
        var products = await _context.Products
            .Include(p => p.Category)
            .ToListAsync();

        return products;
    }

    public async Task<Product> GetItem(int id) {
        var product = await _context.Products
            .Include(p => p.Category)
            .SingleOrDefaultAsync(p => p.Id == id);

        return product;
    }

    public async Task<IEnumerable<Product>> GetItemsByCategory(int id) {
        var products = await _context.Products
            .Include(p => p.Category)
            .Where(p => p.CategoryId == id)
            .ToListAsync();

        return products;
    }
}