using System;
using System.Collections.Generic;

namespace DemoWebServiceScaffoldSqlServer.Models
{
    public partial class Autor
    {
        //Tanto faz inicializar aqui ou na linha da propriedade com =new();
        public Autor()
        {
            Livros = new List<Livro>();
        }

        public int Id { get; set; }
        public string PrimeiroNome { get; set; } = null!;
        public string UltimoNome { get; set; } = null!;

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
