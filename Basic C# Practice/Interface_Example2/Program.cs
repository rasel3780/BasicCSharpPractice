using Interface_Example2;

SavingsAccount savingsAccount1 = new SavingsAccount();
SavingsAccount savingsAccount2 = new SavingsAccount();
SavingsAccount savingsAccount3 = new SavingsAccount();
RegularAccount regularAccount = new RegularAccount();

savingsAccount1.Deposit(500);
savingsAccount2.Deposit(200);
savingsAccount3.Deposit(1500);

List<IBankAccount> bankAccountList =  new List<IBankAccount>();
bankAccountList.Add(savingsAccount1);
bankAccountList.Add(savingsAccount2);
bankAccountList.Add(savingsAccount3);

foreach(IBankAccount bankAccount in bankAccountList)
{
    bankAccount.Deposit(500);
}

foreach (IBankAccount bankAccount in bankAccountList)
{
    Console.WriteLine(bankAccount.Balance);
}

