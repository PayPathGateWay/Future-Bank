using Bank.Domain.Common.Model;
using System;
using Bank.Domain.DTOs;

namespace Bank.Domain.User
{
    /// <summary>
    /// Represents a user entity in the banking domain.
    /// </summary>
    public class User : Entity
    {
 
        /// <param name="userParameters">The parameters for creating a user.</param>
        public User(UserParameters userParameters)
        {
            UserId = userParameters.UserId;
            Username = userParameters.Username ?? throw new ArgumentNullException(nameof(userParameters.Username));
            EmailAddress = userParameters.EmailAddress ?? throw new ArgumentNullException(nameof(userParameters.EmailAddress));
            FullName = userParameters.FullName ?? throw new ArgumentNullException(nameof(userParameters.FullName));
            IsVerified = userParameters.IsVerified;
            Password = userParameters.Password ?? throw new ArgumentNullException(nameof(userParameters.Password));
            UserProfilePath = userParameters.UserProfilePath ?? throw new ArgumentNullException(nameof(userParameters.UserProfilePath));
            Role = userParameters.Role ?? throw new ArgumentNullException(nameof(userParameters.Role));
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid UserId { get; private set; }
        public string Username { get; private set; }
        public string EmailAddress { get; private set; }
        public string FullName { get; private set; }
        public bool IsVerified { get; private set; }
        public string Password { get; private set; }
        public string UserProfilePath { get; private set; }
        public string Role { get; private set; } 
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

    }
}

