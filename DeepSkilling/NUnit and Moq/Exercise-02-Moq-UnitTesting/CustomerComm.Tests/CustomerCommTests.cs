using Moq;using NUnit.Framework;using CustomerCommLib;
namespace CustomerComm.Tests;
[TestFixture]
public class CustomerCommTests{
Mock<IMailSender> mock=null!;
[OneTimeSetUp] public void Init(){mock=new Mock<IMailSender>();}
[TestCase]
public void SendMailToCustomer_ReturnsTrue(){
mock.Setup(m=>m.SendMail(It.IsAny<string>(),It.IsAny<string>())).Returns(true);
var c=new CustomerComm(mock.Object);
Assert.That(c.SendMailToCustomer(),Is.True);
}}