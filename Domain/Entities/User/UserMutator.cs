namespace Domain.Entities;

public partial class User
{
    public static User Create(string name, string email, Role role = Role.User)
    {
        if (IsValidName(name))
            throw new ArgumentException("Name cannot be empty", nameof(name));
        
        if (!IsValidEmail(email))
            throw new ArgumentException("Invalid email format", nameof(email));

        return new User(name, email, role);
    }
    
    public void UpdateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty", nameof(name));
        
        Name = name;
    }

    public void UpdateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty", nameof(email));
        
        if (!IsValidEmail(email))
            throw new ArgumentException("Invalid email format", nameof(email));
        
        Email = email;
    }

    public void UpdateRole(Role role)
    {
        Role = role;
    }
}