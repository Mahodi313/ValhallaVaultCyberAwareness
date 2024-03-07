using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        // General CRUD-funktion for all Repositories
        public Task<T> CreateAsync(T entity);
        public Task<T> DeleteAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task UpdateAsync(T entity);

        // QuestionRepository
        Task<IEnumerable<QuestionModel>> GetQuestionsBySubcategoryAsync(int subcategoryId);
        Task<IEnumerable<AnswerModel>> GetAnswerForQuestionAsync(int questionId);
        Task<IEnumerable<UserResponseModel>> GetUserResponsesForQuestionAsync(int questionId);

        // AnswerRepository
        Task<IEnumerable<AnswerModel>> GetByQuestionIdAsync(int questionId);
        Task<IEnumerable<AnswerModel>> GetCorrectAnswersByQuestionIdAsync(int questionId);

        // SubcategoryRepository
        Task<IEnumerable<SubcategoryModel>> GetSubcategoryBySegmentAsync(int segmentId);
        Task<IEnumerable<QuestionModel>> GetQuestionForSubcategoryAsync(int subcategoryId);
    }
}
