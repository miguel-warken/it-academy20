using Microsoft.EntityFrameworkCore;

using (var contexto = new BloggingContext())
{
    /*
    contexto.Blogs.Add(new Blog
    {
        Nome = "MeuBlog"
    });
    contexto.Blogs.Add(new Blog
    {
        Nome = "OutroBlog"
    });
    contexto.SaveChanges();
    

    var umBlog = contexto.Blogs.Find(1);
    umBlog!.Posts.Add(new Post
    {
        Titulo = "Meu primeiro post!",
        Conteudo = "blablabla"
    });
    contexto.SaveChanges();
    

    var blogEspecifico = contexto.Blogs.Find(2);
    blogEspecifico!.Posts.Add(new Post
    {
        Titulo = "Meu segundo post!",
        Conteudo = "outros assuntos"
    });
    contexto.SaveChanges();
    */

    // var postEspecifico = contexto.Posts.Find(3);
    // postEspecifico!.Comentarios.Add(new Comentario
    // {
    //     Conteudo = "Meu conteudo nao interessa."
    // });
    // contexto.SaveChanges();

    //01.07 EAGER LOADING
    //var umBlog = contexto.Blogs.Find(1);
    // var umBlog = contexto.Blogs
    //                 .Where(b => b.Id == 1)
    //                 .Include(b => b.Posts)
    //                 .FirstOrDefault();

    // System.Console.WriteLine($"{umBlog!.Id} posts:");
    // foreach (var post in umBlog.Posts)
    // {
    //     System.Console.WriteLine($"{post.Titulo}");
    // }

    //EXPLICIT LOADING
    var umBlog = contexto.Blogs.Single(b => b.Id == 1);
    //carregamento dos dados associados em algum momento (ex: agora)
    contexto.Entry(umBlog)
            .Collection(b => b.Posts)
            .Load();
    //neste momento, carregar as entidades associadas (de acordo com tipo)
}