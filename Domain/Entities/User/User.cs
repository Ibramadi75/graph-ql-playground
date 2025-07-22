namespace Domain.Entities;

public partial class User
{
    public int? Id { get; private set; } = null;
    public string Name { get; private set; }
    public string Email { get; private set; }
    public Role Role { get; private set; }

    private User(string name, string email, Role role = Role.User)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty", nameof(name));
        
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty", nameof(email));
        
        if (!IsValidEmail(email))
            throw new ArgumentException("Invalid email format", nameof(email));

        Name = name;
        Email = email;
        Role = role;
    }
}