var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MyBooksAPI>("mybooksapi");

builder.Build().Run();
