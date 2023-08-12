namespace Xo.Core.Smtp.Builders;

public class MimeMessageBuilder : IMimeMessageBuilder
{
    private readonly SmtpOptions _options;

    public MimeMessageBuilder(IOptions<SmtpOptions> options)
        => this._options = options.Value ?? throw new ArgumentNullException(nameof(options));

    public MimeMessage Build(BaseMailQueryResult data)
    {
        var message = new MimeMessage();

        message.From.Add(new MailboxAddress(this._options.FromMailAddress));
        message.To.Add(new MailboxAddress(data.ToEmailAddress));
        message.Subject = data.Subject;
        message.Body = CreateBody(data.Body);

        return message;
    }

    private static MimeEntity CreateBody(string htmlBody)
        => new BodyBuilder() { HtmlBody = htmlBody }.ToMessageBody();
}
