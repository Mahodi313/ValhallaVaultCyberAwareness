using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.Repository;
using ValhallaVaultCyberAwareness.DAL.ViewModel;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public class UserResponseService : IUserResponseService
    {
        private readonly IRepository<UserResponseModel> _userResponseRepo;
        private readonly IRepository<QuestionModel> _questionRepo;

        public UserResponseService(IRepository<UserResponseModel> userResponseRepo, IRepository<QuestionModel> questionRepo)
        {
            _userResponseRepo = userResponseRepo;
            _questionRepo = questionRepo;
        }

        public async Task<int> CalculateSegmentCompletionBasedOnUser(SegmentModel segment, List<UserResponseModel> userResponses)
        {
            int totalQuestions = await _questionRepo.GetTotalQuestionsInSegmentAsync(segment.Id);

            if (totalQuestions == 0)
            {
                return 0;
            }

            // Counts the number of correct answers in a segment where the user has also responded correctly.
            int correctAnswers = _userResponseRepo.GetCorrectAnswersCount(segment.Id, userResponses);

            double percentage = ((double)correctAnswers / totalQuestions) * 100;
            return (int)Math.Round(percentage);
        }

        //Overloaded med viewmodel-version
        public async Task<int> CalculateSegmentCompletionBasedOnUser(SegmentViewModel segment, List<UserResponseModel> userResponses)
        {
            int totalQuestions = await _questionRepo.GetTotalQuestionsInSegmentAsync(segment.Id);

            if (totalQuestions == 0)
            {
                return 0;
            }

            // Counts the number of correct answers in a segment where the user has also responded correctly.
            int correctAnswers = _userResponseRepo.GetCorrectAnswersCount(segment.Id, userResponses);

            double percentage = ((double)correctAnswers / totalQuestions) * 100;
            return (int)Math.Round(percentage);
        }

        public async Task<List<UserResponseModel>> GetUserResponsesAsync(string userId)
        {
            return await _userResponseRepo.GetResponsesOfUser(userId);
        }
    }
}
