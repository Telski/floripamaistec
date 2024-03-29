﻿using FluentValidation;
using System.Reflection.Metadata;
using School.Context;
using Semana.Exercicios.Models;
using Semana.Exercicios.Dtos;
using SchoolContext = School.Context.SchoolContext;
using Semana.Exercicios.Repositories.Interfaces;

namespace Semana.Exercicios.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly SchoolContext _context;

        public QuestionRepository(SchoolContext context)
        {
            _context = context;
        }


        public void Create(Question Question)
        {
            _context.Questions.Add(Question);
            _context.SaveChanges();
        }


        public List<Question> List()
        {
            return _context.Questions.ToList();
        }


        public Question? GetById(int id)
        {
            return _context.Questions.FirstOrDefault(x => x.Id.Equals(id));
        }


        public void Update(Question Question)
        {
            _context.Questions.Update(Question);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var question = GetById(id);
            _context.Questions.Remove(question);
            _context.SaveChanges();
        }
    }
}
