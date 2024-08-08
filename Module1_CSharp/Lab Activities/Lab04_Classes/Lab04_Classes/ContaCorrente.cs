class ContaCorrente
{
    //Attributes
    private decimal balance;
    private string name;
    private DateTime dateOfCreation;
    private decimal avgBalance;
    private uint operationsNumber;

    //Properties
    public decimal Balance { get { return balance; } }

    public string Name { get { return name; } set { name = value; } }

    public DateTime DateOfCreation { get { return dateOfCreation; } }

    public decimal AvgBalance { get { return avgBalance; } }

    //Constructors
    public ContaCorrente(string name, decimal value)
    {
        balance = value;
        this.name = name;
        dateOfCreation = DateTime.Now;
        avgBalance = value;
        operationsNumber = 1;
    }

    public void deposit(decimal value)
    {
        balance += value;
        updateAvgBalance();
    }

    public void withdraw(decimal value)
    {
        balance -= value;
        updateAvgBalance();
    }

    private void updateAvgBalance()
    {
        operationsNumber++;
        avgBalance = balance / operationsNumber;
    }

    public override string ToString()
    {
        return $"Owner: {name} | Balance: {balance} | AVG Balance: {avgBalance} | Operations made: {operationsNumber}";
    }

}