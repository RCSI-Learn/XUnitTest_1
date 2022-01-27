Console.WriteLine("Hello, World!");

XUnitTestExample.MailValidator mailValidator = new XUnitTestExample.MailValidator();
string email = "rcsi@spam.com";
Console.WriteLine(mailValidator.IsValidEmail(email));
Console.WriteLine(mailValidator.IsSpam(email));
