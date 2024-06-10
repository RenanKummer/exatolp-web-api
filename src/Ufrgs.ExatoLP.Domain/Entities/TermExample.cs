namespace Ufrgs.ExatoLP.Domain.Entities;

public class TermExample : UpdatableEntity
{
    public string? Id { get; init; }
    public required Term Term { get; set; }
    public required string ExampleSentence { get; set; }
}
