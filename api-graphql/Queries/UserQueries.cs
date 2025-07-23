using System.Diagnostics.CodeAnalysis;
using api_graphql.Schema;
using Bogus;
using Common;

namespace api_graphql;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
[ExtendObjectType(OperationTypeNames.Query)]
public class UserQueries
{
    public IEnumerable<UserType> GetUsers() => new Faker<UserType>()
        .RuleFor(u => u.Id, f => f.Random.Int(1, 1000))
        .RuleFor(u => u.Name, f => f.Name.FullName())
        .RuleFor(u => u.Email, f => f.Internet.Email())
        .RuleFor(u => u.Role, f => f.PickRandom<Role>())
        .Generate(5);
    
    public IEnumerable<UserType> GetUsersByRole(Role role) => new Faker<UserType>()
        .RuleFor(u => u.Id, f => f.Random.Int(1, 1000))
        .RuleFor(u => u.Name, f => f.Name.FullName())
        .RuleFor(u => u.Email, f => f.Internet.Email())
        .RuleFor(u => u.Role, _ => role)
        .Generate(5);
}