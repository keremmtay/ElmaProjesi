using Microsoft.AspNetCore.Identity;

namespace ElmaProjesi.WebUI.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMale { get; set; }
        public string Age { get; set; }
    }
}
