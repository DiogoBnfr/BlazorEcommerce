using BlazorEcommerce.Models.DTOs;
using System.Net.Http.Json;

namespace BlazorEcommerce.Web.Services;

public class ProductService : IProductService {
    public HttpClient HttpClient;
    public ILogger<ProductService> Logger;

    public ProductService(HttpClient httpClient, ILogger<ProductService> logger) {
        HttpClient = httpClient;
        Logger = logger;
    }

    public async Task<IEnumerable<ProductDTO>?> GetItems() {
        try {
            return await HttpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/Products");
        } catch (Exception) {
            Logger.LogError("Error retrieving products : api/products");
            throw;
        }
    }
}