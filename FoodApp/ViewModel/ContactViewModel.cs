using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Net.Mail;
namespace FoodApp.ViewModel
{
    public class ContactViewModel
    {
        [StringLength(maximumLength:200,ErrorMessage ="between 3 and 200",MinimumLength =3)]
        public string ContactMessage { get; set; }
        [StringLength(maximumLength: 200, ErrorMessage = "between 3 and 200", MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(maximumLength: 200, ErrorMessage = "between 3 and 200", MinimumLength = 3)]
        public string Email { get; set; }
        [EmailAddress]
        public string ContactSubject { get; set; }

        public static void SendEmail(ContactViewModel viewModel)
        {
            MailMessage Msg = new MailMessage();
            SmtpClient SmtpClient = new SmtpClient("smtp.gmail.com");

            Msg.From = new MailAddress(viewModel.Email, viewModel.Name);
            Msg.To.Add("ligomenidis@yahoo.com");
            Msg.Subject = viewModel.ContactSubject;
            Msg.Body = viewModel.ContactMessage;

            SmtpClient.Port = 587;
            SmtpClient.Credentials = new System.Net.NetworkCredential("ligomenidis@yahoo.com", "jenlawrence4tw");
            SmtpClient.EnableSsl = true;

            SmtpClient.Send(Msg);
       
        }
    }
}