using FluentValidation;
using System.Reflection.Metadata;
using School.Context;
using Semana.Exercicios.Models;
using Semana.Exercicios.Dtos;
using SchoolContext = School.Context.SchoolContext;
using Semana.Exercicios.Repositories.Interfaces;

namespace Semana.Exercicios.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly SchoolContext _context;

        public QuizRepository(SchoolContext context)
        {
            _context = context;
        }


        public void Create(Quiz Quiz)
        {
            _context.Quizzes.Add(Quiz);
            _context.SaveChanges();
        }


        public List<Quiz> List()
        {
            return _context.Quizzes.ToList();
        }


        public Quiz? GetById(int id)
        {
            return _context.Quizzes.FirstOrDefault(x => x.Id.Equals(id));
        }


        public void Update(Quiz Quiz)
        {
            _context.Quizzes.Update(Quiz);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var Quiz = GetById(id);
            _context.Quizzes.Remove(Quiz);
            _context.SaveChanges();
        }
    }
}
