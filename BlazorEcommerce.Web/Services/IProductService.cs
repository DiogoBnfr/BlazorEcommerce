using BlazorEcommerce.Models.DTOs;

namespace BlazorEcommerce.Web.Services;

public interface IProductService {
    Task<IEnumerable<ProductDTO>?> GetItems();
}
