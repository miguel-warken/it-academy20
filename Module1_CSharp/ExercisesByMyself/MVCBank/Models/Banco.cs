public class Banco
{
    private List<Cliente> clientes = new List<Cliente>();
    private int nextId;
    public int NextId { get { return nextId; } set { nextId = value; } }
    public List<Cliente> Listaclientes { get { return clientes; } }

    public Banco()
    {
        clientes = new List<Cliente>();
        nextId = 1;
    }

    public bool CadastraClienteEContaNoBanco(Cliente cliente, Conta conta)
    {
        if (!clientes.Contains(cliente))
            clientes.Add(cliente);

        cliente.ListaContas.Add(conta);
        return true;
    }

    public override string ToString()
    {
        string result = "";
        foreach (Cliente cliente in clientes)
        {
            result += cliente.ToString();
            foreach (Conta conta in cliente.ListaContas)
            {
                result += conta.ToString();
                result += "\n";
            }
            result += "\n";
        }
        return result;
    }
}