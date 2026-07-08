// bank account
BankAccount acc1 = new BankAccount("Dilmi", 1000);
acc1.PrintBalance();
acc1.Deposit(500);
acc1.Withdraw(200);
acc1.Withdraw(2000);
acc1.PrintBalance();


BankAccount acc2 = new BankAccount("Kasun", 500);
acc2.Deposit(100);
acc2.PrintBalance();

class BankAccount
{
    public string Owner;
    public double Balance;

    public BankAccount(string owner, double balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount ;
        Console.WriteLine("Deposited : " + amount + ". New balance : " + Balance);
    }

    public void Withdraw(double amount)
    {

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Withdraw  : " + amount + ". New balance : " + Balance);
        }
    }

    public void PrintBalance()
    {
        Console.WriteLine("Owner : " + Owner + ", Balance: " + Balance);
    }
}