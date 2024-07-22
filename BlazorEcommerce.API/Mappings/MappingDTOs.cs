using BlazorEcommerce.API.Entities;
using BlazorEcommerce.Models.DTOs;

namespace BlazorEcommerce.API.Mappings;

public static class MappingDTOs {
    public static IEnumerable<CategoryDTO> ConvertCategoriesToDTO(
        this IEnumerable<Category> categories) {
        return (from category in categories
                select new CategoryDTO {
                    Id = category.Id,
                    Name = category.Name,
                    Icon = category.Icon,
                }).ToList();
    }

    public static IEnumerable<ProductDTO> ConvertProductsToDTO(
        this IEnumerable<Product> products) {
        return (from product in products
                select new ProductDTO {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    ImageUrl = product.ImageUrl,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    CategoryId = product.Category.Id,
                    CategoryName = product.Category.Name
                }).ToList();
    }

    public static ProductDTO ConvertProductToDTO(this Product product) {
        return new ProductDTO {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            ImageUrl = product.ImageUrl,
            Price = product.Price,
            Quantity = product.Quantity,
            CategoryId = product.CategoryId,
            CategoryName = product.Name
        };
    }

    public static IEnumerable<CartItemDTO> ConvertCartItemsToDTO(
        this IEnumerable<CartItem> cartItems, IEnumerable<Product> products) {
        return (from cartItem in cartItems
                join product in products
                    on cartItem.ProductId equals product.Id
                select new CartItemDTO {
                    Id = cartItem.Id,
                    CartId = cartItem.CartId,
                    ProductId = cartItem.ProductId,
                    Quantity = cartItem.Quantity,
                    ProductName = product.Name,
                    ProductDescription = product.Description,
                    ProductImageUrl = product.ImageUrl,
                    Price = product.Price,
                    PriceTotal = product.Price * cartItem.Quantity
                }).ToList();
    }

    public static CartItemDTO ConvertCartItemDTO(
        this CartItem cartItem, Product product) {
        return new CartItemDTO {
            Id = cartItem.Id,
            ProductId = cartItem.ProductId,
            ProductName = product.Name,
            ProductDescription = product.Description,
            ProductImageUrl = product.ImageUrl,
            Price = product.Price,
            CartId = cartItem.CartId,
            Quantity = cartItem.Quantity,
            PriceTotal = product.Price * cartItem.Quantity
        };
    }
}