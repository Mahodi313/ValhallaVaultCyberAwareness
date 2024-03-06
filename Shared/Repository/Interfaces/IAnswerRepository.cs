using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.DAL.Repository.Interfaces
{
    public interface IAnswerRepository : IModelRepository<AnswerModel>
    {
        Task<IEnumerable<AnswerModel>> GetByQuestionIdAsync(int questionId);
        Task<IEnumerable<AnswerModel>> GetCorrectAnswersByQuestionIdAsync(int questionId);
    }
}
