namespace Xo.Core.Smtp.Abstractions;

public interface ISmtpMailClient
{
    Task SendAsync(BaseMailQueryResult data);
}
