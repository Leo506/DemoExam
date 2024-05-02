using DemoExam.Domain.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace DemoExam.Blazor.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class InfoController(IProductsService productsService) : ControllerBase
{
    [HttpGet("categories")]
    public async Task<IActionResult> GetCategories()
    {
        var categories = await productsService.GetCategories().ConfigureAwait(false);
        return Ok(categories);
    }

    [HttpGet("manufacturers")]
    public async Task<IActionResult> GetManufacturers()
    {
        var manufacturers = await productsService.GetManufacturers();
        return Ok(manufacturers);
    }

    [HttpGet("suppliers")]
    public async Task<IActionResult> GetSuppliers()
    {
        var suppliers = await productsService.GetSuppliers();
        return Ok(suppliers);
    }
}