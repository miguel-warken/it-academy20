public class Comentario
{
    public string ComentarioId { get; set; } = null!;
    public string Conteudo { get; set; } = null!;
    public Post Post { get; set; } = null!;
    public int PostId;
}