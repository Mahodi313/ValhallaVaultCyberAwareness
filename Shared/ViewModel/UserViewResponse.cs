namespace Shared.ViewModel
{
    public class UserViewResponse
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
        public UserViewModel User { get; set; }
        public QuestionViewModel Question { get; set; }
    }
}
