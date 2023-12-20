using Spectre.Console;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(c =>
{
    c
    .AddCommand<ValidateCommand>("validate")
    .WithAlias("v")
    .WithDescription("Validate a CHANGELOG.md file syntax");
});

AnsiConsole.Write(new FigletText("Keep a Changelog.NET").Centered().Color(Color.Aqua));
await app.RunAsync(args);