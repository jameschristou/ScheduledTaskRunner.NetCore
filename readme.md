# .NET Core Scheduled Task Runner
This repository shows how to create tasks that can be scheduled to run at a regular interval within a .NET Core application.

## Usage
1. Create a class that implements the abstract base class `ScheduledTaskServiceBase`. Put the code you want to run at the scheduled interval in the `DoWork` method.
2. For a console application, you need to ensure you build the host and also register your hosted services. This requires the `Microsoft.Extensions.Hosting` nuget package. Note that for ASP.NET Core applications, they use WebHost so you just need to register your hosted service.
```
var builder = new HostBuilder()
.ConfigureServices((hostContext, services) =>
{
    // configure services here including registering hosted services
    services.AddHostedService<ExampleScheduledTask>();
});

await builder.RunConsoleAsync();
```

## TestApp
An example usage can be found in the console app project `ScheduledTaskRunner.TestApp`.

### Build
To build the test application just run `dotnet build ScheduledTaskRunner.TestApp.csproj` at the command line inside the project folder.

### Run
To run the test application just run `dotnet run ScheduledTaskRunner.TestApp.csproj` at the command line inside the project folder.