public class ContaCorrente : Conta, ITiposContas
{
    public ContaCorrente(double s, DateTime da, Cliente c) : base(s, da, c)
    {
        TipoDeConta = TipoDeConta.ContaCorrente;
    }
}