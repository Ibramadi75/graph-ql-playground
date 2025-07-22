using api_graphql.Schema;
using Bogus;

namespace api_graphql;

public class Query
{
    public IEnumerable<UserType> GetUsers() => new Faker<UserType>()
        .RuleFor(u => u.Id, f => f.Random.Int(1, 1000))
        .RuleFor(u => u.Name, f => f.Name.FullName())
        .RuleFor(u => u.Email, f => f.Internet.Email())
        .RuleFor(u => u.Role, f => f.PickRandom<RoleType>())
        .Generate(5);
}