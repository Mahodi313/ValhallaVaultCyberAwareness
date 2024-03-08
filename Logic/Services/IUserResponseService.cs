using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValhallaVaultCyberAwareness.DAL.DbModels;

namespace ValhallaVaultCyberAwareness.App.Services
{
    public interface IUserResponseService
    {
        public Task<List<UserResponseModel>> GetUserResponsesAsync(string userId);
        public int CalculateSegmentCompletionBasedOnUser(SegmentModel segment, List<UserResponseModel> userResponses);
    }
}
