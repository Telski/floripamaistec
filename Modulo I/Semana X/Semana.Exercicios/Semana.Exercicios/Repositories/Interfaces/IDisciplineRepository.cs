using Semana.Exercicios.Models;

namespace Semana.Exercicios.Repositories.Interfaces
{
    public interface IDisciplineRepository
    {
        void Create(Discipline discipline);
        List<Discipline> List();
        Discipline? GetById(int id);
        void Update(Discipline discipline);
        void Delete(int id);
    }
}
