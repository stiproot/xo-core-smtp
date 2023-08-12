namespace Xo.Core.Smtp;

public class SmtpMailClient : ISmtpMailClient
{
    private readonly SmtpOptions _options;
    private readonly IMimeMessageBuilder _builder;

    public SmtpMailClient(
      IOptions<SmtpOptions> options,
      IMimeMessageBuilder builder
    )
    {
        this._options = options.Value ?? throw new ArgumentNullException(nameof(options));
        this._builder = builder ?? throw new ArgumentNullException(nameof(builder));
    }

    public async Task SendAsync(BaseMailQueryResult data)
    {
        var message = this._builder.Build(data);

        using (var _smtpClient = new SmtpClient())
        {
            _smtpClient.Connect(this._options.Server, this._options.Port, useSsl: true);
            _smtpClient.Authenticate(this._options.Username, this._options.Password);
            await _smtpClient.SendAsync(message);
        }
    }
}
