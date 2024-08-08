namespace DemoLojinha.Models;

//é um produto e sua quantidade, considerados um item do carrinho
//Será a tabela associativa entre pedido e produto
public class Item
{
    //Posso utilizar o id apenas para evitar chave composta
    // public int Id { get; set; }
    public int Quantidade { get; set; }
    //Usando chave composta (relacionamento N-1 com produto):
    public Produto Produto { get; set; } = null!;
    public int ProdutoId { get; set; }

    //Segunda parte da chave composta (N-1 com Pedido):
    public Pedido Pedido { get; set; } = null!;
    public int PedidoId { get; set; }
}