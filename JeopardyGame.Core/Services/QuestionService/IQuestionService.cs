using JeopardyGame.Domain.DTO;
using JeopardyGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.QuestionService
{
    public interface IQuestionService
    {
        Task Create(QuestionDTO question);
        Task Update(QuestionDTO question);
        Task Remove(QuestionDTO question);
        Task<QuestionDTO> Get(QuestionDTO question);
    }
}
