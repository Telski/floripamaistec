using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.AnswerDto;


namespace Semana.Exercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerRepository _answerRepository;


        public AnswerController(IAnswerRepository AnswerRepository)
        {
            _answerRepository = AnswerRepository;
        }


        //Endpoint criar
        [HttpPost]
        public ActionResult<Answer> Create(Answer answer)
        {
            _answerRepository.Create(answer);

            return CreatedAtAction(nameof(AnswerController), new { id = answer.Id }, answer);
        }


        //Endpoint atualizar
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] AlterAnswerDto AnswerDto)
        {
            var answer = _answerRepository.GetById(id);

            if (answer == null)
                return NotFound();

            answer.Answers = AnswerDto.Answers;
            answer.Score = AnswerDto.Score;
            answer.Observation = AnswerDto.Observation;

            return CreatedAtAction(nameof(AnswerController.Get), new { id = answer.Id }, answer);
        }


        //Endpoint listas
        [HttpGet]
        public IActionResult Get()
        {
            var answers = _answerRepository.List();
            return Ok(answers);
        }


        //Endpoint pegar por id
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var answer = _answerRepository.GetById(id);

            if (answer == null)
                return NotFound();

            return Ok(answer);
        }


        //Endpoint deletar
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteAnswer(int id)
        {
            var answer = _answerRepository.GetById(id);
            if (answer == null)
            {
                return NotFound();
            }

            _answerRepository.Delete(id);

            return NoContent();
        }
    }
}
