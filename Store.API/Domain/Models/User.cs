using System;

namespace Store.API.Domain.Models
{
    class User
    {
        private int UserId { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Username { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private DateTime CreatedAt { get; set; }
        private DateTime LastLogin { get; set; }
        private bool IsActive { get; set; }
    }
}