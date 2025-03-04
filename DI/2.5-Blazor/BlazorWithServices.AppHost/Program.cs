var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithDataVolume("postgres-data")
    .WithPgWeb();

var db = postgres.AddDatabase("Books-postgres");

builder.AddProject<Projects.BlazorWithServices>("blazorwithservices")
    .WithReference(db)
    .WaitFor(db);

builder.Build().Run();
