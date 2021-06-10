using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class Token
    {
        public int Id { get; set; }
        [Required]

        public string RefreshToken { get; set; } = default!;
        [Required]

        public string AccessToken { get; set; } = default!;
        [Required]

        public bool Revoked { get; set; } = false;
        [Required]

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [Required]

        public string User_id { get; set; } = default!;
        public User User { get; set; } = default!;
    }
}
