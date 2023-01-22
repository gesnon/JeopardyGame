using AutoMapper;
using JeopardyGame.Core.Common.Exceptions;
using JeopardyGame.Core.Common.Interfaces;
using JeopardyGame.Core.Models;
using JeopardyGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.QuestionService
{
    public class QuestionService: IQuestionService
    {
        private readonly IAppDbContext context;
        public IQuestionService questionService;
        private readonly IMapper mapper;

        public QuestionService(IAppDbContext context, IQuestionService questionService, IMapper mapper)
        {
            this.context = context;
            this.questionService = questionService;
            this.mapper = mapper;
        }

        public async Task<int> Create(QuestionDto question)
        {
            Question q = mapper.Map<Question>(question);
            
                context.Questions.Add(q);

            await context.SaveChangesAsync(CancellationToken.None);

            return q.Id;
        }

        public async Task Update(QuestionDto question)
        {
            Question q = await context.Questions.FirstOrDefaultAsync(x => x.Id == question.Id);
            if (q == null)
            {
                throw new NotFoundExeption("Вопрос не найден");
            }
            q= mapper.Map<Question>(question);

            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task Remove(int id)
        {
            Question q = await context.Questions.FirstOrDefaultAsync(x => x.Id == id);
            if (q == null)
            {
                throw new NotFoundExeption("Вопрос не найден");
            }
            context.Questions.Remove(q);

            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<QuestionDto> Get(int id)
        {
            Question q = await context.Questions.FirstOrDefaultAsync(x => x.Id == id);
            if (q == null)
            {
                throw new NotFoundExeption("Вопрос не найден");
            }
            return mapper.Map<QuestionDto>(q);
        }
    }
}
