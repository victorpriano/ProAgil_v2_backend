using Microsoft.AspNetCore.Identity;

namespace ProAgil.Domain.Entities.Identity
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; private set; }
        public Role Role { get; private set; }
    }
}