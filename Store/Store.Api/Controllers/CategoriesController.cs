using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService service;

        public CategoriesController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        //[Route("/")]
        //[Route("getAll")]
        public IActionResult GetAll()
        {
            var categories = service.GetAll();

            return Ok(categories);
        }

        //todo: filter by category from query
        //[HttpGet(Name = "GetAll")]
        //public IActionResult GetAll(int id, [FromQuery] string name)
        //{
        //    var filteredCategories = service.GetAll().Where(x => x.CategoryName == name);
        //    return Ok(filteredCategories);
        //}

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public ActionResult<CategoryModel> Get(int id)
        {
            /*
             To implement the action we will need to do the following things:
            Add an action returning an IActionResult, named GetById.
            Add an int parameter to the action named id. This will receive the parameter value from the URL.
            Add a route pattern to match the parameter id:[HttpGet("{id}")].
            Using the service class, search in our list of categories (“database”) for an item that matches the incoming id value. 
                - use service.GetCategory(id);
            Return a 404 Not Found status code if there isn’t an item that matches the id value.
            Return a 200 OK status code and the actual item if we found an item that matches the value.
             */
            var categoryWithId = service.GetCategory(id);
            if (categoryWithId == null)
            {
                return NotFound();             
            }

            return Ok(categoryWithId);
        }

        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var category = service.Add(categoryModel);
            return CreatedAtAction(nameof(GetAll), new { id = category.Categoryid }, category);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CategoryModel model)
        {
            /*
             * To implement the action we will need to do the following things:
            •Use the Service class to search in our database for the item that has the identifier sent in the request. We can refer to this as being the “original” item that we need to update.
            •If we find it, we need to try to update each property with the new values sent in the request body by calling service.Update(model);.
            •If we don’t find the item in our database, return a 404 NotFound status code.
            •Return 200Ok restul and the item that has been updated
             */

            if (id != model.Categoryid)
            {
                return BadRequest();
            }

            //var existingItem = service.GetCategory(id);
            //if (existingItem == null)
            //{
            //    return NotFound();
            //}

            var updatedEntity = service.Update(model);
            if (updatedEntity == null)
            {
                return NotFound();
            }

            return Ok(updatedEntity);
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            /*
             When the request reaches the server, we will have to do the following steps:
 • Use the service class to search in our database for the item that has the identifier sent in the request.
 • If we find it, we simply remove it from the database and return a 204 No Content status code.
 • If we can’t find an item with the specified ID, then we return a 404 Not found status code.
             */

            return Ok();
        }
    }
}
