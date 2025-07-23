using System.Diagnostics.CodeAnalysis;
using Common;

namespace api_graphql.Schema;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class UserType
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Role Role { get; set; } = Role.None;
}