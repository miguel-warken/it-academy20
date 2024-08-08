namespace DemoLojinha.DTOs;

//Novo DTO, pois não há pedido dentro de um carrinho

public class CarrinhoRequisicaoDTO
{
    //Id cliente para identificação do comprador
    public int IdCliente { get; set; }
    public IEnumerable<ItemCarrinhoRequisicaoDTO> Itens { get; set; } = null!;

}
