namespace DemoLojinha.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Telefone { get; set; }
    //Relacionamento 1-N com pedidos
    // public ICollection<Pedido> Pedidos = new List<Pedido>();
    //Posso inicializar agora ou outra hora
    public ICollection<Pedido> Pedidos { get; set; } = null!;
    //Relacionamento N-N com Produto
    public ICollection<Produto> Produtos { get; set; } = null!;
}