using Newtonsoft.Json;

namespace JWT.Models
{
    public class UserModel
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }

    public class UserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
