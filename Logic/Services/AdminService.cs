using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Uow;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUow _unitOfWork;

        public AdminService(IUow unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<AnswerModel>> GetAllAnswersAsync()
        {
            return await _unitOfWork.AnswerRepo.GetAllAsync();
        }
        public async Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync()
        {
            return await _unitOfWork.CategoryRepo.GetAllAsync();
        }

        public async Task AddCategoryAsync(CategoryModel category)
        {
            await _unitOfWork.CategoryRepo.CreateAsync(category);
            await _unitOfWork.SaveChanges();
        }

        public async Task UpdateCategoryAsync(CategoryModel category)
        {
            await _unitOfWork.CategoryRepo.UpdateAsync(category);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            await _unitOfWork.CategoryRepo.DeleteAsync(categoryId);
            await _unitOfWork.SaveChanges();
        }

        // Implement the same pattern for Segments, Subcategories, and Questions
        // Example for Segments:
        public async Task<IEnumerable<SegmentModel>> GetAllSegmentsAsync()
        {
            return await _unitOfWork.SegmentRepo.GetAllAsync();
        }

        public async Task AddSegmentAsync(SegmentModel segment)
        {
            await _unitOfWork.SegmentRepo.CreateAsync(segment);
            await _unitOfWork.SaveChanges();
        }

        public async Task UpdateSegmentAsync(SegmentModel segment)
        {
            await _unitOfWork.SegmentRepo.UpdateAsync(segment);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteSegmentAsync(int segmentId)
        {
            await _unitOfWork.SegmentRepo.DeleteAsync(segmentId);
            await _unitOfWork.SaveChanges();
        }
        public async Task<IEnumerable<SubcategoryModel>> GetAllSubcategoriesAsync()
        {
            return await _unitOfWork.SubcategoryRepo.GetAllAsync();
        }

        public async Task AddSubcategoryAsync(SubcategoryModel subcategory)
        {
            await _unitOfWork.SubcategoryRepo.CreateAsync(subcategory);
            await _unitOfWork.SaveChanges();
        }

        public async Task UpdateSubcategoryAsync(SubcategoryModel subcategory)
        {
            await _unitOfWork.SubcategoryRepo.UpdateAsync(subcategory);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteSubcategoryAsync(int subcategoryId)
        {
            await _unitOfWork.SubcategoryRepo.DeleteAsync(subcategoryId);
            await _unitOfWork.SaveChanges();
        }

        // Question methods
        public async Task<IEnumerable<QuestionModel>> GetAllQuestionsAsync()
        {
            return await _unitOfWork.QuestionRepo.GetAllAsync();
        }

        public async Task AddQuestionAsync(QuestionModel question)
        {
            await _unitOfWork.QuestionRepo.CreateAsync(question);
            await _unitOfWork.SaveChanges();
        }

        public async Task UpdateQuestionAsync(QuestionModel question)
        {
            await _unitOfWork.QuestionRepo.UpdateAsync(question);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteQuestionAsync(int questionId)
        {
            await _unitOfWork.QuestionRepo.DeleteAsync(questionId);
            await _unitOfWork.SaveChanges();
        }


        public async Task AddAnswerAsync(AnswerModel answer)
        {
            if (answer.Id == 0)
            {
                await _unitOfWork.AnswerRepo.CreateAsync(answer);
                await _unitOfWork.SaveChanges();
            }
        }

        public async Task UpdateAnswerAsync(AnswerModel answer)
        {
            await _unitOfWork.AnswerRepo.UpdateAsync(answer);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteAnswerAsync(int answerId)
        {
            await _unitOfWork.AnswerRepo.DeleteAsync(answerId);
            await _unitOfWork.SaveChanges();
        }
    }
}




