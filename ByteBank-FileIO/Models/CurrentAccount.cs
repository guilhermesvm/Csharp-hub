namespace ByteBank_FileIO.Models;

public class CurrentAccount
{
    public int Number { get; set; }
    public int Agency { get; set; }
    public double Balance { get; private set; }
    public Customer AccountHolder  { get; set; }

    public CurrentAccount(int agency, int number)
    {
        Agency = agency;
        Number = number;
    }

    public void Deposit(double amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than zero.", nameof(amount));
        }
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("The amount must be greater than zero.", nameof(amount));
        }

        if(amount > Balance)
        {
            throw new InvalidOperationException("Insufficient balance.");
        }
        Balance -= amount;
    }
}
