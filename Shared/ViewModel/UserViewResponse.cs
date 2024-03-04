namespace Shared.ViewModel
{
    public class UserViewResponse
    {
        // TODO: Fundera ut hur kopplingen mellan användar och dens svar ser ut
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
        public UserViewModel? User { get; set; }
        public QuestionViewModel? Question { get; set; }
    }
}
