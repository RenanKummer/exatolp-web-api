namespace Ufrgs.ExatoLP.Infrastructure.Database.Constants;

public static class PrimaryColumnNames
{
    public const string DomainId = "domain_id";
    public const string GroupId = "group_id";
    public const string PermissionId = "permission_id";
    public const string TagId = "tag_id";
    public const string TermId = "term_id";
    public const string UserId = "user_id";
    public const string ExampleId = "example_id";

    public static readonly string[] TermCompositeId = [TermId, DomainId];
    public static readonly string[] SourceTermCompositeId = ["source_term_id", "source_domain_id"];
    public static readonly string[] DestinationTermCompositeId = ["destination_term_id", "destination_domain_id"];
}
