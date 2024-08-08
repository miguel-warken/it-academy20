using DemoLojinha.DTOs;
using DemoLojinha.Models;
using DemoLojinha.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoLojinha.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IClienteRepository clienteRepository;

    public PedidoController(IClienteRepository clienteRepository)
    {
        this.clienteRepository = clienteRepository;
    }


    //recebo dados de um carrinho e devolvo para usuario dados do pedido
    [HttpPost]
    public async Task<ActionResult<String>> PostNovoPedido(CarrinhoRequisicaoDTO carrinho)
    {
        //Sempre validar o que vem de fora: checar no repositorio se Id do Cliente existe
        var clienteExiste = await clienteRepository.ConsultaSeExiste(carrinho.IdCliente);
        if (!clienteExiste)
        {
            return BadRequest();
        }
        //Validador de objetos recomendado para isso, má pratica no controlador
        return "Ok";
    }
}