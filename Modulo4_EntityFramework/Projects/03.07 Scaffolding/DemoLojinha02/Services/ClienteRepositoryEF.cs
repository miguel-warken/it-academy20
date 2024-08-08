using DemoLojinha.Database;
using Microsoft.EntityFrameworkCore;

namespace DemoLojinha.Services;

public class ClienteRepositoryEF : IClienteRepository
{
    private readonly LojinhaContext contexto;

    public ClienteRepositoryEF(LojinhaContext context)
    {
        this.contexto = context;
    }

    public Task<bool> ConsultaSeExiste(int id)
    {
        return contexto.Clientes.AnyAsync(c => c.Id == id);
    }
}