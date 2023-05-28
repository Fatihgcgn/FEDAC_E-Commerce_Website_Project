using System.Threading.Tasks;

namespace FEDAC.webui.EmailServices
{
    public interface IEmailSender
    {
         // smtp => gmail, hotmail
         //api => sendgrid
         Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}