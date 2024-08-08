using DemoLojinha.Database;
using DemoLojinha.Models;
using DemoLojinha.Services;
using Microsoft.EntityFrameworkCore;

public class ProdutoRepositoryEF : IProdutoRepository
{
    private readonly LojinhaContext contexto;

    public ProdutoRepositoryEF(LojinhaContext contexto)
    {
        this.contexto = contexto;
    }

    public async Task<IEnumerable<Produto>> ConsultarTodosAsync()
    {
        return await contexto.Produtos.OrderBy(p => p.Nome).ToListAsync();
    }
}