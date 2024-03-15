using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUserResponseService _userResponseService;
        private readonly IRepository<SegmentModel> _segmentRepository;
        private readonly IRepository<SubcategoryModel> _subcategoryRepository;
        private readonly IRepository<QuestionModel> _questionRepository;

        public QuestionService(
            IUserResponseService userResponseService,
            IRepository<SegmentModel> segmentRepository,
            IRepository<SubcategoryModel> subcategoryRepository,
            IRepository<QuestionModel> questionRepository)
        {
            _userResponseService = userResponseService;
            _segmentRepository = segmentRepository;
            _subcategoryRepository = subcategoryRepository;
            _questionRepository = questionRepository;
        }

        public async Task<bool> CanAccessQuestion(int segmentId, int subcategoryId, int questionId, string userId)
        {
            // Verifiera att frågan finns inom den angivna subkategorin och segmentet
            var question = await _questionRepository.GetByIdAsync(questionId);
            if (question == null || question.SubcategoryId != subcategoryId)
            {
                return false;
            }

            // Återanvänd logik från IsOpenSubcategory för att kontrollera åtkomst
            bool canAccessSubcategory = await new SubcategoryService(_userResponseService, _segmentRepository, _subcategoryRepository)
                .IsOpenSubcategory(segmentId, subcategoryId, userId);

            if (!canAccessSubcategory)
            {
                return false;
            }

            // Användare har tillåtelse att få tillgång till denna fråga
            return true;
        }
    }
}
