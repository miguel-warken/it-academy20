namespace DemoLojinha.Models;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataEmissao { get; set; }
    //Relacionamento N-1 com cliente
    public Cliente Cliente { get; set; } = null!;
    //Lado "muitos" do relacionamento: chave estrangeira que
    //referencia o objeto cliente
    public int ClienteId { get; set; }

    //Relacionamento 1-N item
    public List<Item> Item { get; set; } = null;
    public ICollection<Produto> Produtos { get; set; } = null!;
}