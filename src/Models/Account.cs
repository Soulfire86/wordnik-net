using System.ComponentModel;

namespace wordnik_net.Models
{
    public class User
    {
        [DefaultValue(0)]
        public long Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public string FaceBookId { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
    }

    public class AuthenticationToken
    {
        public string Token { get; set; }
        public long UserId { get; set; }
        public string UserSignature { get; set; }
    }

    public class ApiTokenStatus
    {
        public bool Valid { get; set; }
        public string Token { get; set; }
        public long ResetsInMillis { get; set; }
        public long ExpiresInMillis { get; set; }
        public long TotalRequests { get; set; }
    }
}