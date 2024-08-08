public abstract class Account
{
    private decimal balance;
    private string owner;

    public Account(string o)
    {
        owner = o;
    }

    public decimal Balance { get { return balance; } set { balance = value; } }

    public string Owner { get { return owner; } set { owner = value; } }

    public abstract string Id { get; }

    public virtual void Deposit(decimal v)
    {
        balance += v;
    }

    public virtual void Withdraw(decimal v)
    {
        balance -= v;
        //decimal newBalance = balance -= v > 0 ? balance -= v : balance;
    }
}