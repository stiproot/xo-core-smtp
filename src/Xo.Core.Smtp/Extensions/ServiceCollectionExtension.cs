namespace Xo.Core.Smtp.Extensions;

public static class MailServiceCollectionExtension
{
    public static IServiceCollection AddSmtpServices(this IServiceCollection @this,
        IConfiguration configuration
    )
    {
        @this.ConfigureOptions<SmtpOptions>(configuration, nameof(SmtpOptions));
        @this.TryAddSingleton<ISmtpMailClient, SmtpMailClient>();
        @this.TryAddSingleton<IMimeMessageBuilder, MimeMessageBuilder>();

        return @this;
    }
}
