// Detta paketet nedan var med i det gamla paketet som var deprecated:
// using Microsoft.AspNet.Identity.EntityFramework;
// **OBS** Detta paketet lades till med följande paket i Shared:
// Microsoft.AspNetCore.Identity.EntityFrameworkCore (8.0.0)
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Shared.DbModels
{
    public class UserResponseModel
    {
        [Key]
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string UserId { get; set; }
        // IdentityUser är fel
        public IdentityUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        public QuestionModel Question { get; set; } = null!;

    }
}
