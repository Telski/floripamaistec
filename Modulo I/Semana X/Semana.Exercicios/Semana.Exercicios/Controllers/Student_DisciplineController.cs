using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.Student_DisciplineDto;

namespace Semana.Exercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Student_DisciplineController : ControllerBase
    {
        private readonly IStudent_DisciplineRepository _student_DisciplineRepository;


        public Student_DisciplineController(IStudent_DisciplineRepository Student_DisciplineRepository)
        {
            _student_DisciplineRepository = Student_DisciplineRepository;
        }


        //Endpoint cria
        [HttpPost]
        public ActionResult<Student_Discipline> Create(Student_Discipline student_discipline)
        {
            _student_DisciplineRepository.Create(student_discipline);

            return CreatedAtAction(nameof(Student_DisciplineController), new { id = student_discipline.Id }, student_discipline);
        }


        //Endpoint lista
        [HttpGet]
        public IActionResult Get()
        {
            var student_Discipline = _student_DisciplineRepository.List();
            return Ok(student_Discipline);
        }


        //Endpoint id
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var student_Discipline = _student_DisciplineRepository.GetById(id);

            if (student_Discipline == null)
                return NotFound();

            return Ok(student_Discipline);
        }


        //Endpoint atualiza
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] AlterStudent_DisciplineDto Student_DisciplineDto)
        {
            var student_Discipline = _student_DisciplineRepository.GetById(id);

            if (student_Discipline == null)
                return NotFound();

            student_Discipline.StudentId = Student_DisciplineDto.StudentId;
            student_Discipline.DisciplineId = Student_DisciplineDto.DisciplineId;

            return CreatedAtAction(nameof(Student_DisciplineController.Get), new { id = student_Discipline.Id }, student_Discipline);
        }


        //Endpoint deleta
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteStudent_Discipline(int id)
        {
            var student_Discipline = _student_DisciplineRepository.GetById(id);
            if (student_Discipline == null)
            {
                return NotFound();
            }

            _student_DisciplineRepository.Delete(id);

            return NoContent();
        }
    }
}
