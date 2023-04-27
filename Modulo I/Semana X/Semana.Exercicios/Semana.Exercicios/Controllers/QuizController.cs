using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.QuizDto;

namespace Semana.Exercicios.Controllers;
[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private readonly IQuizRepository _quizRepository;


    public QuizController(IQuizRepository QuizRepository)
    {
        _quizRepository = QuizRepository;
    }


    //Endpoint criar
    [HttpPost]
    public ActionResult<Quiz> Create(Quiz quiz)
    {
        _quizRepository.Create(quiz);

        return CreatedAtAction(nameof(QuizController), new { id = quiz.Id }, quiz);
    }


    //Endpoint atualizar
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterQuizDto QuizDto)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        quiz.DisciplineId = QuizDto.DisciplineId;
        quiz.Title = QuizDto.Title;

        return CreatedAtAction(nameof(QuizController.Get), new { id = quiz.Id }, quiz);
    }


    //Endpoint listar
    [HttpGet]
    public IActionResult Get()
    {
        var quiz = _quizRepository.List();
        return Ok(quiz);
    }


    //Endpoint id
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var quiz = _quizRepository.GetById(id);

        if (quiz == null)
            return NotFound();

        return Ok(quiz);
    }


    //Endpoint deletar
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteQuiz(int id)
    {
        var quiz = _quizRepository.GetById(id);
        if (quiz == null)
        {
            return NotFound();
        }

        _quizRepository.Delete(id);

        return NoContent();
    }
}