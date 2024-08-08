public class ContaEspecial : Conta, ICredito, ITiposContas
{
    private double limiteCredito;
    public double LimiteCredito { get { return limiteCredito; } set { limiteCredito = value; } }

    public ContaEspecial(double s, DateTime da, Cliente c, double lc) : base(s, da, c)
    {
        TipoDeConta = TipoDeConta.ContaEspecial;
        this.limiteCredito = lc;
    }

    public double getLimiteCredito()
    {
        return limiteCredito;
    }

    public override string ToString()
    {
        return base.ToString() + ", Limite de crédito: " + limiteCredito;
    }
}