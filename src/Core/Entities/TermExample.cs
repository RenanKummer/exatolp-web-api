namespace Ufrgs.ExatoLP.Core.Entities;

public class TermExample : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required Term Term { get; set; }
    public required Domain TermDomain {  get; set; }
    public required string ExampleSentence { get; set; }
}
