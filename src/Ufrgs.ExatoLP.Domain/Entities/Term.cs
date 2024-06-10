using Ufrgs.ExatoLP.Domain.Constants;

namespace Ufrgs.ExatoLP.Domain.Entities;

public class Term : UpdatableEntity
{
    public string? Id { get; init; }
    public required Domain Domain { get; set; }
    public required string Name { get; set; }
    public GrammarNumbers? GrammarNumber { get; set; }
    public GrammarGenders? GrammarGender { get; set; }
    public GrammarCategories? GrammarCategory { get; set; }
    public bool IsAbbreviation { get; set; } = false;
    public bool IsAcronym { get; set; } = false;

    public IEnumerable<TermExample> Examples { get; set; } = [];
    public IEnumerable<TermTag> Tags { get; set; } = [];
}
