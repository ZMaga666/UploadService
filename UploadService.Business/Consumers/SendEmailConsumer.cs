﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadService.Core.Utilities.MailHelper;
using MassTransit;
using UploadService.Entities.SharedModels;

namespace UploadService.Business.Consumers
{
    
    
        public class SendEmailConsumer : IConsumer<SendEmailCommand>
        {
            private readonly IMailSender _mailSender;

            public SendEmailConsumer(IMailSender mailSender)
            {
                _mailSender = mailSender;
            }

            public async Task Consume(ConsumeContext<SendEmailCommand> context)
            {
                var message = $"https://localhost:7037/api/user/verifyemail?email={context.Message.Email}&token={context.Message.Token}";
                //_mailSender.SendMail(context.Message.Email, message, true);
            }
        }
    
}
