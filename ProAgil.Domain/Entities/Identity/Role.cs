using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ProAgil.Domain.Entities.Identity
{
    public class Role : IdentityRole<int>
    {
        public IReadOnlyCollection<UserRole> UserRoles { get; private set; }
    }
}