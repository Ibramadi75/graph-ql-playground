using api_graphql;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .RegisterQueries();

var app = builder.Build();

app.MapGraphQL();

app.Run();
