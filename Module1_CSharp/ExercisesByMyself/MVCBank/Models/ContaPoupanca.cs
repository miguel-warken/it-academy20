
public class ContaPoupanca : Conta, IJuros, ITiposContas
{
    private double juros;
    public double Juros { get; set; }

    public ContaPoupanca(double s, DateTime da, Cliente c, double j) : base(s, da, c)
    {
        TipoDeConta = TipoDeConta.ContaCorrente;
        this.juros = j;
    }

    public double calculaJuros()
    {
        return Saldo *= Juros;
    }
}
