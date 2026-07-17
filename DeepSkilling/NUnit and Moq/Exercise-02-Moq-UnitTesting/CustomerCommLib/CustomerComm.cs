namespace CustomerCommLib;
public class CustomerComm{
private readonly IMailSender _mail;
public CustomerComm(IMailSender mail){_mail=mail;}
public bool SendMailToCustomer(){_mail.SendMail("cust123@abc.com","Some Message");return true;}
}