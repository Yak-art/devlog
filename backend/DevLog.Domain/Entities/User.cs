namespace DevLog.Domain.Entities
{
    /// <summary>
    /// Пользователь системы.
    /// </summary>
    public class User : BaseEntity
    {
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private User() { }

        public User(string email, string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be empty", nameof(email));

            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
