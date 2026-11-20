using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository_Pattern.Models;

namespace Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
        public class StudentController : ControllerBase
        {
            private readonly StudentService _service;

            public StudentController(StudentService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetStudents()
            {
                var students = await _service.GetStudents();

                return Ok(students);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetStudent(int id)
            {
                var student = await _service.GetStudentById(id);

                if (student == null)
                    return NotFound();

                return Ok(student);
            }

            [HttpPost]
            public async Task<IActionResult> AddStudent(Student student)
            {
                await _service.AddStudent(student);

                return Ok("Student Added Successfully");
            }

            [HttpPut]
            public async Task<IActionResult> UpdateStudent(Student student)
            {
                await _service.UpdateStudent(student);

                return Ok("Student Updated Successfully");
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteStudent(int id)
            {
                await _service.DeleteStudent(id);

                return Ok("Student Deleted Successfully");
            }
        }

    }
