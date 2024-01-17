
namespace CleanArchitecture.Application.Abstractions.Email;

public interface IEmailService
{
    Task SeedAsync(Domain.Users.Email recipient, string subject, string body);
}
