namespace api_graphql.Schema;

public class UserType
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public RoleType Role { get; set; } = RoleType.None;
}