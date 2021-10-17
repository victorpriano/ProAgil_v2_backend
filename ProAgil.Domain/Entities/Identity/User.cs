using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProAgil.Domain.Entities.Identity
{
    public class User : IdentityUser<int>
    {
        [Column(TypeName = "nvarchar(150)")]

        public string FullName { get; private set; }
        public IReadOnlyCollection<UserRole> UserRoles { get; private set; }
    }
}