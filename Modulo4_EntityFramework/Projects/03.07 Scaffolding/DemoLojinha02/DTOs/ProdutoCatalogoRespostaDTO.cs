using DemoLojinha.Models;

namespace DemoLojinha.DTOs;

public class ProdutoCatalogoRespostaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? Descricao { get; set; } = null!;
    public string PrecoUnitario { get; set; } = null!;

    public static ProdutoCatalogoRespostaDTO DeModelParaDto(Produto produto)
    {
        ProdutoCatalogoRespostaDTO dto = new ProdutoCatalogoRespostaDTO();
        dto.Id = produto.Id;
        dto.Nome = produto.Nome;
        dto.Descricao = produto.Descricao;
        //Assumindo que veremos em reais decimais (por isso 100M) e usando
        //o :C para aparecer como Currency do SERVIDOR
        dto.PrecoUnitario = $"{produto.PrecoUnitario / 100M:C}";

        return dto;
    }
}