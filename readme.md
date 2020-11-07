# .NET Core Scheduled Task Runner
This repository shows how to create tasks that can be scheduled to run at a regular interval within a .NET Core application.

## Usage
1. Create a class that implements `IScheduledTask`. Put the code you want to run at the scheduled interval in the `Run` method.
2. Register the class, for example
```
var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IScheduledTask, ExampleScheduledTask>();
```
3. Ensure you call the `ServiceProvider` extension method `SetUpScheduledTasks()` after creating the service provider.

## TestApp
An example usage can be found in the console app project `ScheduledTaskRunner.TestApp`.

### Build
To build this application just run `dotnet build StartUpTaskRunner.csproj` at the command line.

### Run
To run this application just run `dotnet run StartUpTaskRunner.csproj` at the command line.