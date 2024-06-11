using FirstAppi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppi.Controllers
{
    [Route("api/[controller]")] //localhost:{port}/api/students
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student>();

        public StudentsController()
        {
            students = new List<Student>()
                {
                    new Student { Id=1,  FirstName = "John", LastName = "Doe", Age = 20, Grade = 3.8 },
                    new Student { Id=2, FirstName = "Jane", LastName = "Smith", Age = 21, Grade = 3.6 },
                    new Student { Id=3, FirstName = "Alice", LastName = "Johnson", Age = 19, Grade = 3.9 },
                    new Student { Id=4, FirstName = "Bob", LastName = "Williams", Age = 22, Grade = 3.3 },
                    new Student { Id=5, FirstName = "Emily", LastName = "Brown", Age = 20, Grade = 3.7 }
                };
        }


        [HttpGet]
        public IActionResult GetAllStudents()//GetAll  //localhost:{port}/api/students
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        //CREATE 
        [HttpPost] //localhost:{port}/api/students?gender=gender
        public IActionResult Create([FromBody] Student student, [FromHeader] string? culture, [FromQuery] string? gender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //simulate the db saving

            student.Id = 100;
            students.Add(student);


            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }


        [HttpPut("{id}")] // //localhost:{port}/api/students/2
        public IActionResult UpdateStudent(int id, Student model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            var studentFromDb = students.FirstOrDefault(x => x.Id == id);

            //equivalent to
            //Student studentFromDb2;
            //foreach (var x in students)
            //{
            //    if (x.Id == id)
            //    {
            //        studentFromDb2 = x;
            //        break;
            //    }
            //}

            if (studentFromDb == null)
            {
                return NotFound();

            }
            //update in the database
            //todo: update with the new values

            return Ok(studentFromDb);
            // return Ok();
        }


        [HttpHead("{id}")]
        public IActionResult CheckIfExists(int id)
        {
            if (students.Any(x => x.Id == id))
            {
                return Ok();
            }
            return NotFound();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var studentWithId = students.FirstOrDefault(x => x.Id == id);
            if (studentWithId == null)
            {
                return NotFound();
            }

            students.Remove(studentWithId);
            return NoContent();
        }
    }
}
