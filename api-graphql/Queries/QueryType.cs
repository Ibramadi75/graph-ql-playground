using System.Diagnostics.CodeAnalysis;
using HotChocolate.Execution.Configuration;

namespace api_graphql;

[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
public class Query { }

public static class QueryType
{
    public static void RegisterQueries(this IRequestExecutorBuilder builder)
    {
        builder.AddQueryType<Query>()
               .AddTypeExtension<UserQueries>()
               .AddTypeExtension<RoleQueries>();
    }
}