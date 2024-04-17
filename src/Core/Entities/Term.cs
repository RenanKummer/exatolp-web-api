using Ufrgs.ExatoLP.Core.Constants;

namespace Ufrgs.ExatoLP.Core.Entities;

public class Term : UpdatableEntity
{
    public string Id { get; set; } = string.Empty;
    public required Domain Domain { get; set; }
    public required string Name { get; set; }
    public GrammarNumbers? GrammarNumber { get; set; }
    public GrammarGenders? GrammarGender { get; set; }
    public GrammarCategories? GrammarCategory { get; set; }
    public bool IsAbbreviation { get; set; } = false;
    public bool IsAcronym { get; set; } = false;
}
