namespace Bank.Domain.DTOs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class.
    /// </summary>
    /// <param name="UserId">The unique identifier for the user.</param>
    /// <param name="Username">The username of the user.</param>
    /// <param name="EmailAddress">The email address of the user.</param>
    /// <param name="FullName">The full name of the user.</param>
    /// <param name="IsVerified">Indicates whether the user is verified.</param>
    /// <param name="Password">The user's password.</param>
    /// <param name="UserProfilePath">The path to the user's profile.</param>
    /// <param name="Role">The role of the user for authorization.</param>
    public record UserParameters(
        Guid UserId, 
        string Username, 
        string EmailAddress,
        string FullName, 
        bool IsVerified, 
        string Password,
        string UserProfilePath, 
        string Role
    );
}



