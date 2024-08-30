var builder = DistributedApplication.CreateBuilder(args);

var pg = builder.AddPostgres("postgres")
    .WithPgAdmin()
    .AddDatabase("weather");

var apiService = builder.AddProject<Projects.CSnakesAspire_ApiService>("apiservice")
    .WithReference(pg);

builder.AddProject<Projects.CSnakesAspire_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();