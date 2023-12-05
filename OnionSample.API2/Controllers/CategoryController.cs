using Microsoft.AspNetCore.Mvc;
using OnionSample.Application.Interfaces;

namespace OnionSample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            try
            {
                var categories = _categoryService.GetAllCategories();
                return Ok(categories);

            }
            catch (Exception rx)
            {

                throw rx;
            }
        }
        // Diğer API metodları...
    }
}
