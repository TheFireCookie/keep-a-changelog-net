// See https://aka.ms/new-console-template for more information
using Spectre.Console;

AnsiConsole.WriteLine("Hello, World!");
var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");