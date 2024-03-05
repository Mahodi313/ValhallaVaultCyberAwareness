using Shared.ApiModels;
namespace Shared.ApiModel
{
    public class UserApiModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<UserResponseApiModel> Responses { get; set; } = new();


    }
}
