using Escola.Models;
using Escola.Repositories;
using Microsoft.AspNetCore.Mvc;
using Escola.Dtos;
namespace Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunosRepository _alunosRepository;

        public AlunoController()
        {
            _alunosRepository = new AlunosRepository();
        }

        [HttpGet]
        public ActionResult<List<AlunoModel>> Get([FromQuery] string nome)
        {
            var alunos = _alunosRepository.ListarAlunosPorNome(nome);
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public ActionResult<AlunoModel> Get(int id)
        {
            var aluno = _alunosRepository.ObterAlunoPorId(id);

            if (aluno == null)
            {
                return NotFound(); // Status code 404
            }

            return Ok(aluno); // Status code 200
        }
        
        
        //Criar Aluno
        [HttpPost]
        public ActionResult<AlunoModel> CriarAluno([FromBody] AlunoDto alunoDto)
        {
            var repository = new AlunosRepository();
            var aluno = repository.CriarAluno(alunoDto);
            return CreatedAtAction(nameof(AlunoController.Get), new{id = aluno.Id },aluno);
        }

        [HttpDelete]                       //Exclui dados
        [Route("{id}")]
        public ActionResult<AlunoModel> Excluir(int id)
        {
            var repository = new AlunosRepository();
            repository.ExcluirAluno(id);
            return NoContent();
        }
    }
}

