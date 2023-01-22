using JeopardyGame.Core.Models;

namespace JeopardyGame.Core.Services.QuestionService
{
    public interface IQuestionService
    {
        Task Create(QuestionDto question);

        Task Update(QuestionDto question);

        Task Remove(QuestionDto question);

        Task<QuestionDto> Get(QuestionDto question);
    }
}
