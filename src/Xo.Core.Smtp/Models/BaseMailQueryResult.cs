namespace Xo.Core.Smtp.Models;

public class BaseMailQueryResult : BaseQueryResult, IQueryResult
{
    public short MailStatusId { get; init; }
    public string Subject { get; init; } = string.Empty;
    public string Body { get; init; } = string.Empty;
    public string ToEmailAddress { get; init; } = string.Empty;
}
