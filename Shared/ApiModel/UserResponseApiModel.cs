using Microsoft.AspNet.Identity.EntityFramework;

namespace Shared.ApiModels
{
    public class UserResponseApiModel
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        public QuestionApiModel Question { get; set; } = null!;

    }
}
