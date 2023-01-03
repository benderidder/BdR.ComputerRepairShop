using System.Threading.Tasks;

namespace BdR.ComputerRepairShop.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
