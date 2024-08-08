public class Cliente
{
    private string nome;
    private DateTime dataNascimento;
    private int id;
    private List<Conta> listaContas;
    public List<Conta> ListaContas { get { return listaContas; } set { listaContas = value; } }
    public int Id { get { return id; } set { id = value; } }
    public string Nome { get { return nome; } set { nome = value; } }
    public DateTime DataNascimento { get { return dataNascimento; } set { dataNascimento = value; } }

    public Cliente(string n, DateTime dn, Banco banco)
    {
        this.id = banco.NextId++;
        nome = n;
        dataNascimento = dn;
        listaContas = new List<Conta>();
    }

    public Cliente(string n, DateTime dn, Conta c)
    {
        nome = n;
        dataNascimento = dn;
        listaContas = new List<Conta>() { c };
    }

    public void AdicionaContaAoCliente(Conta conta)
    {
        listaContas.Add(conta);
    }

    public override string ToString()
    {
        return $"Nome: {nome} de ID {Id}\n"; ;
    }

}