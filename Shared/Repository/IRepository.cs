using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        // General CRUD-funktion for all Repositories
        public Task<T> CreateAsync(T entity);
        public Task<T> DeleteAsync(int id);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task UpdateAsync(T entity);

        // QuestionRepository
        Task<List<QuestionModel>> GetQuestionsBySubcategoryAsync(int subcategoryId);
        Task<List<AnswerModel>> GetAnswerForQuestionAsync(int questionId);
        Task<List<UserResponseModel>> GetUserResponsesForQuestionAsync(int questionId);

        // AnswerRepository
        Task<List<AnswerModel>> GetByQuestionIdAsync(int questionId);
        Task<List<AnswerModel>> GetCorrectAnswersByQuestionIdAsync(int questionId);

        // SubcategoryRepository
        Task<List<SubcategoryModel>> GetSubcategoryBySegmentAsync(int segmentId);
        Task<List<QuestionModel>> GetQuestionForSubcategoryAsync(int subcategoryId);

        //Category
        Task<List<CategoryModel>> GetCategoryIncludeSegmentAsync();

        // UserResponse 
        public Task<List<UserResponseModel>> GetResponsesOfUser(string userid);
    }
}
