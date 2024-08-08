namespace DemoLojinha.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? Descricao { get; set; }
    public int PrecoUnitario { get; set; }
    //Relacionamento N-N com Pedido
    public ICollection<Pedido> Pedidos { get; set; } = null!;

    //Relacionamento 1-N item
    public List<Item> Item { get; set; } = null;
}