using System.Diagnostics.CodeAnalysis;
using api_graphql.Schema;

namespace api_graphql;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
[ExtendObjectType(OperationTypeNames.Query)]
public class RoleQueries
{
    public IEnumerable<RoleType> GetRoles() => [RoleType.None, RoleType.User, RoleType.Admin];
}