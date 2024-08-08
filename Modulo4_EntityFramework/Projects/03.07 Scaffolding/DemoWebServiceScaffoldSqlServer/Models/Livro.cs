using System;
using System.Collections.Generic;

namespace DemoWebServiceScaffoldSqlServer.Models
{
    public partial class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        //Diferentemente de Autor, aqui eu instanciei as listas diretamente na linha, sem ser por construtor
        public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

        public virtual ICollection<Autor> Autores { get; set; } = new List<Autor>();

    }
}
