using BlazorEcommerce.API.Mappings;
using BlazorEcommerce.API.Repositories;
using BlazorEcommerce.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItems()
    {
        try
        {
            var products = await _productRepository.GetItems();
            if (products is null)
            {
                return NotFound();
            }
            var productsDTO = products.ConvertProductsToDTO();
            return Ok(productsDTO);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Failed to access database!");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductDTO>> GetItem(int id)
    {
        try
        {
            var product = await _productRepository.GetItem(id);
            if (product is null)
            {
                return NotFound("Failed to localize product");
            }

            var productDTO = product.ConvertProductToDTO();
            return Ok(productDTO);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Failed to access database!");
        }
    }

    [HttpGet]
    [Route("GetItemsByCategory/{categoryId:int}")]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetItemsByCategory(int categoryId)
    {
        try
        {
            var products = await _productRepository.GetItemsByCategory(categoryId);
            var productsDTO = products.ConvertProductsToDTO();
            return Ok(productsDTO);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Failed to access database");
        }
    }
}