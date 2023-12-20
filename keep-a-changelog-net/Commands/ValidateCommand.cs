using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;

internal sealed class ValidateCommand : Command<ValidateCommand.Settings>
{
  public sealed class Settings : CommandSettings
  {
    [Description("Path to the file. If not specified, it will search recursively for a file named changelog.md")]
    [CommandArgument(0, "[path]")]
    public string? Path { get; init; }
  }

  public override int Execute(CommandContext context, Settings settings)
  {
    if (settings.Path == null)
    {
      AnsiConsole.MarkupLine($"Path is null, we will search for a changelog.md file recursively");
      Directory.GetFiles(".", "changelog.md", searchOption: SearchOption.AllDirectories);
    }

    return 0;
  }
}