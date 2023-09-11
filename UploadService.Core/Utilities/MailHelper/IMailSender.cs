using System;

namespace UploadService.Core.Utilities.MailHelper
{
    public interface IMailSender
    {
        bool SendMail(string mailAddress, string message, bool bodyHtml);
    }
}

