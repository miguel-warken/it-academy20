using DemoLojinha.Models;

namespace DemoLojinha.Services;

public interface IClienteRepository
{
    Task<bool> ConsultaSeExiste(int Id);
}