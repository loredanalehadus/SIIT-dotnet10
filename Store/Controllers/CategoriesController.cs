using Microsoft.AspNetCore.Mvc;
using Store.Services;

namespace Store.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        // add CRUD operations with the specific verbs
        private ICategoryService service;

        public CategoriesController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = service.GetAll();

            return Ok(service.GetAll());
        }
    }
}
