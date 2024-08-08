public abstract class Conta
{
    private double saldo;

    private DateTime dataAbertura;

    private Cliente donoDaConta;

    private TipoDeConta tipoDeConta;

    public TipoDeConta TipoDeConta { get { return tipoDeConta; } set { tipoDeConta = value; } }

    public Cliente DonoDaConta { get { return donoDaConta; } set { donoDaConta = value; } }

    public double Saldo { get { return saldo; } set { saldo = value; } }

    public DateTime DataAbertura { get { return dataAbertura; } set { dataAbertura = value; } }

    public Conta(double s, DateTime da, Cliente c)
    {
        saldo = s;
        dataAbertura = DateTime.Now;
        donoDaConta = c;
    }

    public virtual bool Saque(double val)
    {
        if (val < 0)
            return false;

        if (saldo - val >= 0)
        {
            saldo -= val;
            return true;
        }
        else
        {
            System.Console.WriteLine("Saldo insuficiente para sacar: " + val);
        }
        return false;
    }

    public virtual void Depositar(double val)
    {
        saldo += val;
    }

    public override string ToString()
    {
        return $"-> Dono: {DonoDaConta.Nome}, Saldo: {Saldo}, Data de Abertura da conta: {dataAbertura}, Tipo de Conta: {tipoDeConta}".PadLeft(5);
    }
}