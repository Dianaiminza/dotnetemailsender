using System;
using System.Net;
using System.Net.Mail;
using FluentEmail.Core;
using FluentEmail.Smtp;

namespace FluentEmailExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.your-email-provider.com")
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("your-email@example.com", "your-email-password"),
                EnableSsl = true,
                Port = 587
            });

            Email.DefaultSender = sender;

            var email = await Email
                .From("your-email@example.com")
                .To("recipient@example.com", "Recipient Name")
                .Subject("Test Email")
                .Body("This is a test email sent using FluentEmail.", false)
                .SendAsync();

            if (email.Successful)
            {
                Console.WriteLine("Email sent successfully!");
            }
            else
            {
                Console.WriteLine("Failed to send email. Errors: " + string.Join(", ", email.ErrorMessages));
            }
        }
    }
}
