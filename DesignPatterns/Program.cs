// Encapsulation

using DesignPatterns.OOPPrinciples.Encapsulation;

BadBankAccount badBankAccount = new BadBankAccount();
badBankAccount.balance = 100;
Console.WriteLine(badBankAccount.balance);

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(70);
Console.WriteLine(bankAccount.GetBalance());