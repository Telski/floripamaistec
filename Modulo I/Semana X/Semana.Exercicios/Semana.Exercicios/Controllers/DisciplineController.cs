using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.DisciplineDto;


namespace Semana.Exercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineRepository _disciplineRepository;


        public DisciplineController(IDisciplineRepository DisciplineRepository)
        {
            _disciplineRepository = DisciplineRepository;
        }


        //Endpoint criar
        [HttpPost]
        public ActionResult<Discipline> Create(Discipline discipline)
        {
            _disciplineRepository.Create(discipline);

            return CreatedAtAction(nameof(DisciplineController), new { id = discipline.Id }, discipline);
        }


        //Endpoint atualizar
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] AlterDisciplineDto DisciplineDto)
        {
            var discipline = _disciplineRepository.GetById(id);

            if (discipline == null)
                return NotFound();

            discipline.TeacherId = DisciplineDto.TeacherId;
            discipline.NameDiscipline = DisciplineDto.NameDiscipline;

            return CreatedAtAction(nameof(DisciplineController.Get), new { id = discipline.Id }, discipline);
        }


        //Endpoint listar
        [HttpGet]
        public IActionResult Get()
        {
            var discipline = _disciplineRepository.List();
            return Ok(discipline);
        }


        //Endpoint id
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var discipline = _disciplineRepository.GetById(id);

            if (discipline == null)
                return NotFound();

            return Ok(discipline);
        }


        //Endpoint deletar
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteAnswer(int id)
        {
            var answer = _disciplineRepository.GetById(id);
            if (answer == null)
            {
                return NotFound();
            }

            _disciplineRepository.Delete(id);

            return NoContent();
        }
    }
}