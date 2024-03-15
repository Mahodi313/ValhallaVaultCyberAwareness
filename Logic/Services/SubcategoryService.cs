using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class SubcategoryService : ISubcategoryService
    {
        private readonly IUserResponseService _userResponseService;
        private readonly IRepository<SegmentModel> _SegmentRepository;
        private readonly IRepository<SubcategoryModel> _SubcategoryRepository;

        public SubcategoryService(IUserResponseService userResponseService, IRepository<SegmentModel> segmentRepository, IRepository<SubcategoryModel> subcategoryRepository)
        {
            _userResponseService = userResponseService;
            _SegmentRepository = segmentRepository;
            _SubcategoryRepository = subcategoryRepository;
        }

        public async Task<bool> IsOpenSubcategory(int segmentId, int subcategoryId, string userId)
        {
            try
            {


                var subcategory = await _SubcategoryRepository.GetByIdAsync(subcategoryId);
                if (subcategory == null || subcategory.SegmentId != segmentId)
                {
                    return false;
                }

                var segment = await _SegmentRepository.GetByIdAsync(segmentId);
                var firstSegmentId = await GetFirstSegmentIdForCategory(segment.CategoryId);
                if (segmentId == firstSegmentId)
                {
                    return true;
                }

                int? previousSegmentId = await GetPreviousSegmentId(segmentId, segment.CategoryId);

                if (previousSegmentId != null)
                {
                    var completionRate = await CalculateCompletionRate(previousSegmentId.Value, userId);
                    if (completionRate < 80)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private async Task<int> CalculateCompletionRate(int segmentId, string userId)
        {
            var subcategories = await _SubcategoryRepository.GetSubcategoriesBySegmentAsync(segmentId);
            var responses = await _userResponseService.GetUserResponsesAsync(userId);
            var correctResponsesCount = responses.Count(r => r.IsCorrect);

            var totalQuestionsCount = subcategories.Sum(sc => sc.Questions.Count);
            var completionRate = (totalQuestionsCount > 0) ? (correctResponsesCount / (float)totalQuestionsCount) * 100 : 0;

            return (int)completionRate;
        }

        private async Task<int?> GetFirstSegmentIdForCategory(int categoryId)
        {
            var allSegments = await _SegmentRepository.GetAllAsync();
            var segmentsForCategory = allSegments.Where(s => s.CategoryId == categoryId);
            var firstSegment = segmentsForCategory.OrderBy(s => s.Id).FirstOrDefault();

            return firstSegment?.Id;
        }

        private async Task<int?> GetPreviousSegmentId(int currentSegmentId, int categoryId)
        {
            var allSegments = await _SegmentRepository.GetAllAsync();
            var segmentsInCategory = allSegments.Where(s => s.CategoryId == categoryId).ToList();
            var orderedSegments = segmentsInCategory.OrderBy(s => s.Id).ToList();
            var currentIndex = orderedSegments.FindIndex(s => s.Id == currentSegmentId);

            if (currentIndex <= 0)
            {
                return null;
            }

            return orderedSegments[currentIndex - 1].Id;
        }
    }
}
