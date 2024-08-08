namespace DemoLojinha.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoLojinha.Models;
using DemoLojinha.Services;
using Microsoft.EntityFrameworkCore.Metadata;
using DemoLojinha.DTOs;

[ApiController]
[Route("api/v1/[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly IProdutoRepository produtoRepository;

    public CatalogoController(IProdutoRepository produtoRepository)
    {
        this.produtoRepository = produtoRepository;
    }

    //GET .../api/v1/catalogo -> quero todos os itens
    [HttpGet]
    public async Task<IEnumerable<ProdutoCatalogoRespostaDTO>> GetTodos()
    {
        //Só vou retornar os dados relevantes de produto, então: DTO
        var produtos = await produtoRepository.ConsultarTodosAsync();
        return produtos.Select(ProdutoCatalogoRespostaDTO.DeModelParaDto);
    }
}