using DemoConsoleSqlServer.Models;

Console.WriteLine("Iniciando conexão");
using (var contexto = new TarefaContext())
{
    Console.WriteLine("Inserindo dados...");
    contexto.Tarefas.Add(new Tarefa
    {
        Nome = "Estudar .NET",
        Completa = false,
    });
    contexto.Tarefas.Add(new Tarefa
    {
        Nome = "Lavar a louça",
        Completa = true
    });
    contexto.SaveChanges();
    System.Console.WriteLine("Dados inseridos e salvados");
}

