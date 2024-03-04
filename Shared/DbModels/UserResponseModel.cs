using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class UserResponseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;

    }
}
