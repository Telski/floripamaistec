
using Escola.Models;
using Microsoft.AspNetCore.Mvc;
using Escola.Dtos;



namespace Escola.Repositories
{
    public  class AlunosRepository
    {
        private static List<AlunoModel> _alunos = new List<AlunoModel>(){
            new AlunoModel { Id = 1, Nome = "Cesar"},
            new AlunoModel { Id = 2, Nome = "Jose"},
            new AlunoModel { Id = 3, Nome = "Joao"}
        };
        public List<AlunoModel> ListarAlunosPorNome(string nome)
                {
                    // Converter o nome informado para lowercase para ignorar o case-sensitive
                    nome = nome.ToLower();

                    // Verificar se o nome não foi informado, caso contrário, retornar a lista completa de alunos
                    if (string.IsNullOrEmpty(nome))
                    {
                        return _alunos;
                    }

                    // Filtrar os alunos com base no nome informado
                    var alunosFiltrados = _alunos
                        .Where(aluno => aluno.Nome != null && aluno.Nome.ToLower().Contains(nome))
                    .ToList();

            return alunosFiltrados;
                }
        public AlunoModel ObterAlunoPorId(int id)
                {
                    var aluno = _alunos.FirstOrDefault(aluno => aluno.Id == id);
                    return aluno ?? new AlunoModel();
                }
        public AlunoModel CriarAluno(AlunoDto dto)
            {
                var Alunos = new AlunoModel();
                Alunos.Id = GerarId();
                Alunos.Nome = dto.Nome;

                _alunos.Add(Alunos);

                return Alunos;
            }

        private ActionResult<AlunoModel> Ok(AlunoModel aluno)
        {
            throw new NotImplementedException();
        }
        
        public void ExcluirAluno(int id)
            {
                var Alunos = _alunos.FirstOrDefault(a => a.Id == id);                       //Pesquisa se tem algum objeto com o Id informado, se tiver retorna o mesmo. Senao retorna null
                if (Alunos != null)
                    _alunos.Remove(Alunos);
            }
        private int GerarId()
            {
                return _alunos.Last().Id + 1;
            }
    }
}
