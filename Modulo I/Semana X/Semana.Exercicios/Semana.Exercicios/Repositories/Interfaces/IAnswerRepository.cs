﻿using Semana.Exercicios.Models;

namespace Semana.Exercicios.Repositories.Interfaces
{
    public interface IAnswerRepository
    {
        void Create(Answer Answer);
        List<Answer> List();
        Answer? GetById(int id);
        void Update(Answer Answer);
        void Delete(int id);
    }
}
