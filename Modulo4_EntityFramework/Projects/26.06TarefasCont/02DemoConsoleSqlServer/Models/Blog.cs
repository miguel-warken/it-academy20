public class Blog
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    //Ja cria para nao ser nula
    public List<Post> Posts { get; set; } = new();
}