public class SavingsAccount : Account
{
    private decimal interestRate;
    private DateTime anniversaryDate;

    public SavingsAccount(decimal i, DateTime d, string o) : base(o)
    {
        interestRate = i;
        anniversaryDate = d;
    }

    public decimal Interest { get { return interestRate; } set { interestRate = value; } }

    public DateTime AnniversaryDate { get { return anniversaryDate; } set { anniversaryDate = value; } }

    public void addIncome()
    {
        DateTime today = DateTime.Now;
        if (today.Day == anniversaryDate.Day && today.Month == anniversaryDate.Month)
        {
            decimal income = this.Balance * interestRate;
            this.Deposit(income);
        }
    }

    public override string Id
    {
        get { return this.Owner + "SA"; }
    }
}