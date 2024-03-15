using ValhallaVaultCyberAwareness.DAL.DbModels;
using ValhallaVaultCyberAwareness.DAL.ViewModel;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface IUserResponseService
    {
        public Task<List<UserResponseModel>> GetUserResponsesAsync(string userId);
        public Task<int> CalculateSegmentCompletionBasedOnUser(SegmentModel segment, List<UserResponseModel> userResponses);
        public Task<int> CalculateSegmentCompletionBasedOnUser(SegmentViewModel segment, List<UserResponseModel> userResponses);
    }
}
