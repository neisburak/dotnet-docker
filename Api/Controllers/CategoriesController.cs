using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id, CancellationToken cancellationToken) => Ok(await _categoryService.GetAsync(id, cancellationToken));

    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken) => Ok(await _categoryService.GetAsync(cancellationToken));
}