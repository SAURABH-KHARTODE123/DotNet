using Banking;
using Taxation;
using Notification;
using System.Threading;

Account acct = new Account();

acct.Balance = 65000;
acct.Deposit(200);
Console.WriteLine("current balance: " + acct.Balance);


// Direct call -- Synchronous call
TaxationService.PayIncomeTax(4500);
TaxationService.PaySalesTax(4500);

NotificationService.SendEmail("Ameya","Welcome to Company");
NotificationService.SendSMS("Saurabh","Nice meeting you");

Console.WriteLine("\n \n \n Asynchronous calling using delegate");



TaxOperation proxyPayIncomeTax = new TaxOperation(TaxationService.PayIncomeTax);
proxyPayIncomeTax(5000);

// attach functions to delegates 
NotificationOperation proxySendEmail = new NotificationOperation(NotificationService.SendEmail);
NotificationOperation proxySendSMS = new NotificationOperation(NotificationService.SendSMS);
NotificationOperation proxySendWhatsApp = new NotificationOperation(NotificationService.SendWhatsApp);

NotificationOperation proxy = null;

// chaining 
proxy += proxySendEmail;
proxy += proxySendSMS;
proxy += proxySendWhatsApp;

proxy("Somesh", "You are genius");

proxy.Invoke("Yash", "You are Extra-ordinary");


// Indirect call -- Asynchronous call
// IAsyncResult IResult = proxy.BeginInvoke("Pranav","Welcome to Nagpur",null,null);

// proxy.EndInvoke(IResult);


Thread currentThread = Thread.CurrentThread;
int threadId = currentThread.ManagedThreadId;
Console.WriteLine("Thread Id: " + threadId);
Console.WriteLine("Thread priority: " + currentThread.Priority);

Account acc1 = new Account();

acc1.overBalance += TaxationService.PayIncomeTax;
acc1.underBalance += NotificationService.SendEmail;

/*
acc1.Balance = 200000;
acc1.Deposit(60000);
Console.WriteLine(acc1.Balance);
*/

acc1.Balance = 160000;
acc1.Withdraw(159000);

