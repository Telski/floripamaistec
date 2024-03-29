﻿using Semana.Exercicios.Models;

namespace Semana.Exercicios.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        void Create(Question Question);
        List<Question> List();
        Question? GetById(int id);
        void Update(Question Question);
        void Delete(int id);
    }
}
