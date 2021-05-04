using HotChocolate;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        //[Required, StringLength(200)]
        public string? Surname { get; set; }
        //[Required, StringLength(200)]
        public string? Patronymic { get; set; }
        [GraphQLIgnore]
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }
    }
}
