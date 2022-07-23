using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NayeemApp.Services.ProjectEmailService.EmailService.Interface
{
    public interface IEmailService
    {
        Task SendEmail(string email, string firstName, string lastName, string callbackUrl, string subject, string actionName);
    }
}
