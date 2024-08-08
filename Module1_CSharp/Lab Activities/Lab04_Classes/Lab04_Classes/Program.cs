namespace Lab04_Classes;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente minhaConta = new ContaCorrente("Minguel", 100);
        minhaConta.deposit(50);
        minhaConta.withdraw(100);
        minhaConta.deposit(1000);
        minhaConta.withdraw(500);

        System.Console.WriteLine(minhaConta.ToString());
    }
}
