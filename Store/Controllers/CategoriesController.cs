using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        // add CRUD operations with the specific verbs
        private ICategoryRespository respository;

        public CategoriesController(ICategoryRespository respository)
        {
            this.respository = respository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(respository.GetAll());
        }
    }
}
