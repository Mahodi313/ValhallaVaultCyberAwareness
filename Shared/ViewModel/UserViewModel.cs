namespace Shared.ViewModel
{
    public class UserViewModel
    {
        public string Id { get; set; } = null!;
        public string Username { get; set; } = null!;
        public List<UserViewResponse> UserResponses { get; set; } = new();
    }
}
