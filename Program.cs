using GraphQL_Sample.Repository;
using HotChocolate.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting().AddGraphQLServer().AddQueryType<VideoQuery>();

var app = builder.Build();

app.UseRouting();
app.MapGraphQL();
app.UsePlayground();
app.UseHttpsRedirection();

app.Run();
