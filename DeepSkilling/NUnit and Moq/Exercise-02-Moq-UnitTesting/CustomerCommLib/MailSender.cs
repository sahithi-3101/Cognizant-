using System.Net;using System.Net.Mail;
namespace CustomerCommLib;
public class MailSender:IMailSender{
public bool SendMail(string to,string message){
var mail=new MailMessage();var smtp=new SmtpClient("smtp.gmail.com");
mail.From=new MailAddress("your_email_address@gmail.com");mail.To.Add(to);mail.Subject="Test Mail";mail.Body=message;
smtp.Port=587;smtp.Credentials=new NetworkCredential("username","password");smtp.EnableSsl=true;
//smtp.Send(mail);
return true;
}}