using Microsoft.AspNetCore.Mvc;
using Semana.Exercicios.Models;
using Semana.Exercicios.Repositories.Interfaces;
using static Semana.Exercicios.Dtos.TeacherDto;

namespace Semana.Exercicios.Controllers;
[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherRepository _teacherRepository;


    public TeacherController(ITeacherRepository TeacherRepository)
    {
        _teacherRepository = TeacherRepository;
    }


    //Endpoint criar
    [HttpPost]
    public ActionResult<Teacher> Create(Teacher teacher)
    {
        _teacherRepository.Create(teacher);

        return CreatedAtAction(nameof(TeacherController), new { id = teacher.Id }, teacher);
    }


    //Endpoint atualizar
    [HttpPut]
    [Route("{id}")]
    public IActionResult Update(int id, [FromBody] AlterTeacherDto TeacherDto)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        teacher.UserId = TeacherDto.UserId;
        teacher.Department = TeacherDto.Department;

        return CreatedAtAction(nameof(TeacherController.Get), new { id = teacher.Id }, teacher);
    }


    //Endpoint lista
    [HttpGet]
    public IActionResult Get()
    {
        var teacher = _teacherRepository.List();
        return Ok(teacher);
    }


    //Endpoint id
    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(int id)
    {
        var teacher = _teacherRepository.GetById(id);

        if (teacher == null)
            return NotFound();

        return Ok(teacher);
    }


    //Endpoint deleta
    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteATeacher(int id)
    {
        var teacher = _teacherRepository.GetById(id);
        if (teacher == null)
        {
            return NotFound();
        }

        _teacherRepository.Delete(id);

        return NoContent();
    }
}
