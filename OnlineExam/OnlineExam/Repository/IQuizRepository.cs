using OnlineExam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExam.Repository
{
    public interface IQuizRepository
    {
        Task CreateQuizAsync(Quiz quiz);

        Task<Quiz> GetQuizAsync(int id);

        Task<ICollection<Quiz>> GetAllQuizzesAsync();

        void DeleteQuiz(Quiz quiz);
    }
}
