namespace Lab06_ClassesAbstratas;
class Program
{
    static void Main(string[] args)
    {
        LinkedList<Account> accountsList = new LinkedList<Account>();
        accountsList.AddLast(new SavingsAccount(1.25m, DateTime.Now, "Minguel"));
        accountsList.AddLast(new SavingsAccount(2.25m, DateTime.Now, "Minguel2"));
        accountsList.AddLast(new SavingsAccount(3.25m, DateTime.Now, "Minguel3"));

        foreach (Account account in accountsList)
        {
            System.Console.WriteLine(account.Id);
            //It is possible to use Deposit, Equals, Id, ToString, Withdraw methods.
            //Also possible to use the public properties.
        }

    }
}
