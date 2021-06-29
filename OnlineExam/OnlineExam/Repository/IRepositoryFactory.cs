using System.Data;
using System.Threading.Tasks;

namespace OnlineExam.Repository
{
    public interface IRepositoryFactory
    {
        IUserRepository GetUserRepository();

        IQuestionRepository GetQuestionRepository();

        IQuizRepository GetQuizRepository();

        Task<IDbTransaction> BeginTransactionAsync();

        Task SaveAsync();
    }
}
