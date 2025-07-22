namespace Domain.Entities;

public partial class User
{
    private static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email cannot be empty", nameof(email));

        return IsEmail(email);
    }
    
    private static bool IsEmail(string email)
    {
        return email.Contains('@') && email.Contains('.');
    }
    
    private static bool IsValidName(string name)
    {
        return !string.IsNullOrWhiteSpace(name) && name.Length <= 100;
    }
}