using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.DAL.Repository.Interfaces
{
    public interface IQuestionRepository : IModelRepository<QuestionModel>
    {
        Task<IEnumerable<QuestionModel>> GetQuestionsBySubcategoryAsync(int subcategoryId);
        Task<IEnumerable<AnswerModel>> GetAnswerForQuestionAsync(int questionId);
        Task<IEnumerable<UserResponseModel>> GetUserResponsesForQuestionAsync(int questionId);
    }
}
