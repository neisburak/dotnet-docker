using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken) => Ok(await _productService.GetAsync(id, cancellationToken));

    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken) => Ok(await _productService.GetAsync(cancellationToken));
}