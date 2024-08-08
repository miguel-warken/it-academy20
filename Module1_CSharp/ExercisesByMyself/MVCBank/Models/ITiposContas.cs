public enum TipoDeConta
{
    ContaCorrente, ContaEspecial, ContaPoupanca
}

interface ITiposContas
{
    TipoDeConta TipoDeConta { get; }
}