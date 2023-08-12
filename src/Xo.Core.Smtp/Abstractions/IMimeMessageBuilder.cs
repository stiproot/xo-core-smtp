namespace Xo.Core.Smtp.Abstractions;

public interface IMimeMessageBuilder
{
    MimeMessage Build(BaseMailQueryResult data);
}
