using System.Diagnostics.CodeAnalysis;
using api_graphql.Schema;
using Common;

namespace api_graphql;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
[ExtendObjectType(OperationTypeNames.Query)]
public class RoleQueries
{
    public IEnumerable<Role> GetRoles() => [Role.None, Role.User, Role.Admin];
}