﻿using FluentValidation;
using System.Reflection.Metadata;
using Semana.Exercicios.Models;
using Semana.Exercicios.Dtos;
using SchoolContext = School.Context.SchoolContext;
using Semana.Exercicios.Repositories.Interfaces;

namespace Semana.Exercicios.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly SchoolContext _context;

        public AnswerRepository(SchoolContext context)
        {
            _context = context;
        }


        public void Create(Answer Answer)
        {
            _context.Answers.Add(Answer);
            _context.SaveChanges();
        }


        public List<Answer> List()
        {
            return _context.Answers.ToList();
        }


        public Answer? GetById(int id)
        {
            return _context.Answers.FirstOrDefault(x => x.Id.Equals(id));
        }


        public void Update(Answer Answer)
        {
            _context.Answers.Update(Answer);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var answer = GetById(id);
            _context.Answers.Remove(answer);
            _context.SaveChanges();

        }
    }
}
