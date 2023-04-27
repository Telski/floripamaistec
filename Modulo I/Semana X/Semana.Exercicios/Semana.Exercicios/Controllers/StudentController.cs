using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.StudentDto;

namespace Semana.Exercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;


        public StudentController(IStudentRepository StudentRepository)
        {
            _studentRepository = StudentRepository;
        }


        //Endpoint criar
        [HttpPost]
        public ActionResult<Student> Create(Student student)
        {
            _studentRepository.Create(student);

            return CreatedAtAction(nameof(StudentController), new { id = student.Id }, student);
        }


        //Endpoint atualizar
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] AlterStudentDto StudentDto)
        {
            var student = _studentRepository.GetById(id);

            if (student == null)
                return NotFound();

            student.UserId = StudentDto.UserId;
            student.Period = StudentDto.Period;
            student.RA = StudentDto.RA;

            return CreatedAtAction(nameof(StudentController.Get), new { id = student.Id }, student);
        }


        //Endpoint lsita
        [HttpGet]
        public IActionResult Get()
        {
            var student = _studentRepository.List();
            return Ok(student);
        }


        //Endpoint id
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentRepository.GetById(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }


        //Endpoint exclui
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _studentRepository.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            _studentRepository.Delete(id);

            return NoContent();
        }
    }
}
