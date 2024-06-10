namespace Ufrgs.ExatoLP.Domain.Configs;

public record ConnectionStringConfigs
{
    public string Postgres { get; init; } = string.Empty;
}
