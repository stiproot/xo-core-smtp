namespace Xo.Core.Smtp.Models;

public class SmtpOptions
{
    public int Port { get; init; }
    public string Server { get; init; } = string.Empty;
    public string FromMailAddress { get; init; } = string.Empty;
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public string TemplateDirPath { get; init; } = string.Empty;
    public string EmailConfirmationUrl { get; init; } = string.Empty;
    public string MeetingGatwayUrl { get; init; } = string.Empty;
}
