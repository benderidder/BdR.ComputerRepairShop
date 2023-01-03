using BdR.ComputerRepairShop.Core.Interfaces;

namespace BdR.ComputerRepairShop.Infrastructure;

public class FakeEmailSender : IEmailSender
{
  public Task SendEmailAsync(string to, string from, string subject, string body)
  {
    return Task.CompletedTask;
  }
}
