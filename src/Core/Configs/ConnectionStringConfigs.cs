namespace Ufrgs.ExatoLP.Core.Configs;

public record ConnectionStringConfigs
{
    public string Postgres { get; init; } = string.Empty;
}
