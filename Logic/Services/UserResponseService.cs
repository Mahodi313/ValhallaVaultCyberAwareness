using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.DAL.ViewModel;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class UserResponseService : IUserResponseService
    {
        private readonly IRepository<UserResponseModel> _userResponseRepo;

        public UserResponseService(IRepository<UserResponseModel> userResponseRepo)
        {
            _userResponseRepo = userResponseRepo;
        }

        public int CalculateSegmentCompletionBasedOnUser(SegmentModel segment, List<UserResponseModel> userResponses)
        {
            int totalQuestions = segment.Subcategorys.SelectMany(sc => sc.Questions).Count();

            if (totalQuestions == 0)
            {
                return 0;
            }

            // Counts the number of correct answers in a segment where the user has also responded correctly.
            int correctAnswers = segment.Subcategorys
                .SelectMany(sc => sc.Questions)
                .SelectMany(q => q.Answers)
                .Count(a => a.IsCorrectAnswer && userResponses.Any(ur => ur.QuestionId == a.Id && ur.IsCorrect));

            double percentage = ((double)correctAnswers / totalQuestions) * 100;
            return (int)Math.Round(percentage);
        }

        //Overloaded med viewmodel-version
        public int CalculateSegmentCompletionBasedOnUser(SegmentViewModel segment, List<UserResponseModel> userResponses)
        {
            int totalQuestions = segment.Subcategories.SelectMany(sc => sc.Questions).Count();

            if (totalQuestions == 0)
            {
                return 0;
            }

            // Counts the number of correct answers in a segment where the user has also responded correctly.
            int correctAnswers = segment.Subcategories
                .SelectMany(sc => sc.Questions)
                .SelectMany(q => q.Answers)
                .Count(a => a.IsCorrectAnswer && userResponses.Any(ur => ur.QuestionId == a.Id && ur.IsCorrect));

            double percentage = ((double)correctAnswers / totalQuestions) * 100;
            return (int)Math.Round(percentage);
        }

        public async Task<List<UserResponseModel>> GetUserResponsesAsync(string userId)
        {
            return await _userResponseRepo.GetResponsesOfUser(userId);
        }
    }
}
