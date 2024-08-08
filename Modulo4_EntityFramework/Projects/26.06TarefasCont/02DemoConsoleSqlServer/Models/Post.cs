public class Post
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public string Conteudo { get; set; } = null!;
    //Apenas um blog (para varios posts)
    public Blog Blog { get; set; } = null!;
    public int BlogId { get; set; }
    public List<Comentario> Comentarios { get; set; } = new();
}