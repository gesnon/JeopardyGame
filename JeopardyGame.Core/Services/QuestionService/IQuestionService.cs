using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services.QuestionService
{
    public interface IQuestionService
    {
        Task<int> Create(QuestionDto question);

        Task Update(QuestionDto question);

        Task Remove(int id);

        Task<QuestionDto> Get(int id);
    }
}
