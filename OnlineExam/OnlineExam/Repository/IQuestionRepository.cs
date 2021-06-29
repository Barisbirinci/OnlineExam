using OnlineExam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExam.Repository
{
    public interface IQuestionRepository
    {
        Task CreateQuestionAsync(Question question);

        Task<ICollection<Question>> GetAllQuestionsAsync(int quizId);
    }
}
