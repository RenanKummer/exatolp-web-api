namespace Ufrgs.ExatoLP.Core.Entities;

public class Author : EntityBase
{
    public string Id { get; set; } = string.Empty;
    public required string FullName { get; set; }
}
