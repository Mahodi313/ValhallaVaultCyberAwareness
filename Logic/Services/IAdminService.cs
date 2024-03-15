using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<AnswerModel>> GetAllAnswersAsync();
        Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync();
        Task<IEnumerable<SegmentModel>> GetAllSegmentsAsync();
        Task<IEnumerable<SubcategoryModel>> GetAllSubcategoriesAsync();
        Task<IEnumerable<QuestionModel>> GetAllQuestionsAsync();

        //CategoryMethods
        Task AddCategoryAsync(CategoryModel category);
        Task UpdateCategoryAsync(CategoryModel category);
        Task DeleteCategoryAsync(int categoryId);
        // Segment methods
        Task AddSegmentAsync(SegmentModel segment);
        Task UpdateSegmentAsync(SegmentModel segment);
        Task DeleteSegmentAsync(int segmentId);

        // Subcategory methods
        Task AddSubcategoryAsync(SubcategoryModel subcategory);
        Task UpdateSubcategoryAsync(SubcategoryModel subcategory);
        Task DeleteSubcategoryAsync(int subcategoryId);

        // Question methods
        Task AddQuestionAsync(QuestionModel question);
        Task UpdateQuestionAsync(QuestionModel question);
        Task DeleteQuestionAsync(int questionId);

        Task AddAnswerAsync(AnswerModel answer);
        Task UpdateAnswerAsync(AnswerModel answer);
        Task DeleteAnswerAsync(int answerId);


    }
}
