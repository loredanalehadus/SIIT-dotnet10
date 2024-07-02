using Cupcakes.Data;
using Cupcakes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cupcakes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CupcakeController : ControllerBase
    {
        private CupcakeContext context;

        public CupcakeController(CupcakeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAllCupcakes()
        {
            return Ok(context.Cupcakes.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cupcake = context.Cupcakes.SingleOrDefault(c => c.CupcakeId == id);
            if (cupcake == null)
            {
                return NotFound();
            }
            return Ok(cupcake);
        }

        //CREATE
        [HttpPost]
        public IActionResult Create([FromBody] Cupcake cupcake)
        {
            //todo: need to fix this using models, otherwise will get validation error
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Cupcakes.Add(cupcake);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = cupcake.CupcakeId }, cupcake);
        }

        //UPDATE
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Cupcake model)
        {
            if (id != model.CupcakeId)
            {
                return BadRequest();
            }

            var cupcakeFromDb = context.Cupcakes.SingleOrDefault(c => c.CupcakeId == id);

            if (cupcakeFromDb == null)
            {
                return NotFound();
            }

            //update in the database
            var updatedEntity = context.Cupcakes.Update(cupcakeFromDb);
            context.SaveChanges();

            return Ok(updatedEntity);
        }

        [HttpHead("{id}")]
        public IActionResult CheckIfExists(int id)
        {
            var cupcakeWithId = context.Cupcakes.SingleOrDefault(c => c.CupcakeId == id);

            if (cupcakeWithId != null)
            {
                return Ok();
            }
            return NotFound();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cupcakeWithId = context.Cupcakes.SingleOrDefault(c => c.CupcakeId == id);

            if (cupcakeWithId == null)
            {
                return NotFound();
            }

            context.Cupcakes.Remove(cupcakeWithId);
            context.SaveChanges();

            return NoContent();
        }
    }
}
