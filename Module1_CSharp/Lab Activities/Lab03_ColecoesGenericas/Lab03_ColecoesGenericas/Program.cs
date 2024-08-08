using System.Xml.Schema;

namespace Lab03_ColecoesGenericas;
class Program
{
    static void Main(string[] args)
    {
        List<string> listaStrings = new List<string>();
        listaStrings.Add("Um");
        listaStrings.Add("Hello");
        listaStrings.Add("World");
        Console.WriteLine(listaStrings[0]);
        Console.WriteLine(listaStrings[1]);
        Console.WriteLine(listaStrings[2]);
        listaStrings.Add("10");

        Queue<Object> q = new Queue<Object>();
        q.Enqueue("\n.Net Framework");
        q.Enqueue(new Decimal(123.456));
        q.Enqueue(654.321);
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());

        Queue<int> minhaFila = new Queue<int>();
        minhaFila.Enqueue(10);
        minhaFila.Enqueue(200);
        minhaFila.Enqueue(1000);
        Console.WriteLine(minhaFila.Dequeue());
        Console.WriteLine(minhaFila.Dequeue());
        Console.WriteLine(minhaFila.Dequeue());

        Dictionary<int, string> paises = new Dictionary<int, string>();
        paises[44] = "Reino Unido";
        paises[33] = "França";
        paises[55] = "Brasil";
        Console.WriteLine("O código 55 é: {0}", paises[55]);
        foreach (var item in paises)
        {
            int codigo = item.Key;
            string pais = item.Value;
            Console.WriteLine("Código {0} = {1}", codigo, pais);

        }
        //Isso gera uma excecao (quando chave é nula)
        //Console.WriteLine("O código 30 é: {0}", paises[30]);

        //Isso funciona:
        paises[30] = null;
        Console.WriteLine("O código 30 é: {0}", paises[30]);

        //Para recuperar o código DDI, podemos adicionar o país na posição que seria seu DDI:
        var myKey = paises.FirstOrDefault(x => x.Value == "Brasil").Key;
        System.Console.WriteLine(myKey);

        totalAcimaDaMedia();
    }

    public static void totalAcimaDaMedia()
    {
        List<int> listaInt = new List<int>
        {
             1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> novaLista = new List<int>();

        //5.5
        double avg = listaInt.Average();

        List<int> media = listaInt.Where(x => x > avg).ToList();

        int cont = media.Count;

        media.ForEach(x => System.Console.WriteLine(x));
        System.Console.WriteLine("Tamanho lista:" + cont);
    }
}
