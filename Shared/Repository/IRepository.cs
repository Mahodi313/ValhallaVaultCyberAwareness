using System.Linq.Expressions;
using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        // General CRUD-funktion for all Repositories
        public Task<T> CreateAsync(T entity);
        public Task<T> DeleteAsync(int id);
        public Task<List<T>> GetAllAsync();
        public Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        //public Task<Dictionary<string, object>> GetAllMetaAsync<T>(T entity) where T : class;
        public Task<T> GetByIdAsync(int id);
        public Task<T> GetByIdAsync(string id);
        public Task UpdateAsync(T entity);

        // QuestionRepository
        Task<List<QuestionModel>> GetQuestionsBySubcategoryAsync(int subcategoryId);
        Task<List<AnswerModel>> GetAnswerForQuestionAsync(int questionId);
        Task<List<UserResponseModel>> GetUserResponsesForQuestionAsync(int questionId);

        // AnswerRepository
        Task<List<AnswerModel>> GetAnswersByQuestionIdAsync(int questionId);
        Task<List<AnswerModel>> GetCorrectAnswersByQuestionIdAsync(int questionId);

        // SubcategoryRepository
        Task<List<SubcategoryModel>> GetSubcategoryBySegmentAsync(int segmentId);
        Task<List<QuestionModel>> GetQuestionForSubcategoryAsync(int subcategoryId);

        //Category Repository
        Task<List<CategoryModel>> GetCategoryIncludeSegmentAsync();
        Task<CategoryModel?> GetCategoryWithSegmentIdAsync(int segmentId);

        // UserResponse Repository
        Task<List<UserResponseModel>> GetResponsesOfUser(string userid);
        Task<List<SubcategoryModel>> GetSubcategoriesBySegmentAsync(int segmentId);
        Task<UserResponseModel> FindByUserAndQuestionAsync(string userId, int questionId);
        Task<IEnumerable<UserResponseModel>> GetByUserIdAndSegmentIdAsync(string userId, int segmentId);
        Task<UserResponseModel?> GetUserResponseAsync(string userId, int questionId, int answerId);
        UserResponseModel? GetUserResponse(string userId, int questionId, int answerId);
    }
}
