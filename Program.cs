using Spectre.Console;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(c =>
{
    c
    .AddCommand<ValidateCommand>("validate")
    .WithAlias("v")
    .WithDescription("Validate a CHANGELOG.md file");
    c.AddCommand<UpdateCommand>("update")
    .WithAlias("u")
    .WithDescription("Update a CHANGELOG.md file, thus replacing Unreleased by the next version");
});

AnsiConsole.Write(new FigletText("Keep a Changelog.NET").Centered().Color(Color.Aqua));
await app.RunAsync(args);