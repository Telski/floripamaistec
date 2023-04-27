using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.QuestionDto;

namespace Semana.Exercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;


        public QuestionController(IQuestionRepository QuestionRepository)
        {
            _questionRepository = QuestionRepository;
        }


        //Endpoint criar
        [HttpPost]
        public ActionResult<Question> Create(Question question)
        {
            _questionRepository.Create(question);

            return CreatedAtAction(nameof(QuestionController), new { id = question.Id }, question);
        }


        //Endpoint atualizar
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, [FromBody] AlterQuestionDto QuestionDto)
        {
            var question = _questionRepository.GetById(id);

            if (question == null)
                return NotFound();

            question.QuizId = QuestionDto.QuizId;
            question.Enunciation = QuestionDto.Enunciation;
            question.Weight = QuestionDto.Weight;

            return CreatedAtAction(nameof(QuestionController.Get), new { id = question.Id }, question);
        }


        //Endpoint listas
        [HttpGet]
        public IActionResult Get()
        {
            var question = _questionRepository.List();
            return Ok(question);
        }


        //Endpoint id
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var question = _questionRepository.GetById(id);

            if (question == null)
                return NotFound();

            return Ok(question);
        }


        //Endpoint deletar
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteQuestion(int id)
        {
            var question = _questionRepository.GetById(id);
            if (question == null)
            {
                return NotFound();
            }

            _questionRepository.Delete(id);

            return NoContent();
        }
    }
}
