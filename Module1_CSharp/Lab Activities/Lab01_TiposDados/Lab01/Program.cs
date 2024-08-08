namespace Lab01;
class Program
{
    static void Main(string[] args)
    {

        //firstExercises();
        //ex01();
        //ex02();
        //ex03();
        //ex04();
        //ex05();
        //ex06();
        //ex07();
        ex08();
    }

    static void firstExercises()
    {
        //1.2.:
        byte b;
        b = byte.MaxValue;
        Console.WriteLine("Byte max value: " + b);
        //Console.WriteLine($"Byte max value: {b}");

        //1.5.:
        int i;
        i = int.MaxValue;
        Console.WriteLine("Int max value: " + i);

        //1.8.:
        long l;
        l = long.MaxValue;
        Console.WriteLine("Long max value: " + l);

        //2.1.:
        string firstStr = "Hello ";
        string secondStr = "World";
        string thirdStr = firstStr + secondStr;
        Console.WriteLine(thirdStr);

        //2.4
        int strSize = thirdStr.Length;
        string fourthStr = "Size = " + strSize.ToString();
        Console.WriteLine("Size of third string: " + fourthStr);
        Console.WriteLine("Third String cut: 0,5 " + thirdStr.Substring(0, 5));

        //3.1
        DateTime dt = new DateTime(2015, 04, 23);
        string fifthStr = dt.ToString();
        Console.WriteLine("DateTime.ToString(): " + fifthStr);
    }

    static void ex01()
    {

        float floatNum = 0.251456f;

        float result = floatNum * 0.03f;
        Console.WriteLine($"\nResult of {floatNum} * 0.03: " + result);
        result = floatNum * 0.0003f;
        Console.WriteLine($"\nResult of {floatNum} * 0.0003: {result}, data omission, necessary other data type");

        double newResult = result;
        Console.WriteLine($"\nResult of {floatNum} * 0.0003: {newResult}, utilizing double it has more precision");

        decimal lastResult = (decimal)result * 2.54674123321m;
        Console.WriteLine($"\nResult of {result} * 2.54674123321: {lastResult}, utilizing decimal (even more precision because of more space)");

    }

    static void ex02()
    {
        //One operation for each purpose
        //1: Creating Strings:
        //String.Insert(int32, String): inserts a string at specified index

        string baseStr = "Otolaryngology";
        string insertedStr = "ITacademy20";


        Console.WriteLine($"\nBefore: {baseStr}\nAfter (6): {baseStr.Insert(7, insertedStr)}");

        //2: String.Trim() 
        baseStr = "Hi there my name is Miguel!";
        char[] mychar = { 'l', 'e', 'u', 'M', 'i', 'g', '!' };
        Console.WriteLine($"Before: {baseStr}\nAfter trim: {baseStr.Trim()}");
        Console.WriteLine($"Before: {baseStr}\nAfter trimEnd: {baseStr.TrimEnd(mychar)}");

        //3: String.PadLeft(): new string has the size it was stipulated (adding stuff to the left)
        baseStr = "Hi";
        Console.WriteLine($"Before: {baseStr}\nAfter padding: {baseStr.PadLeft(10, '-')}");

        //4: comparison and equals
        baseStr = "Hi People";
        string strToCompare = "Hi There";
        Console.WriteLine($"Are {baseStr} and {strToCompare} strings equal: {baseStr.Equals(strToCompare)}\nDo they start with \"Hi\": {(baseStr.StartsWith("Hi") && strToCompare.StartsWith("Hi"))} ");
    }

    static void ex03()
    {
        DateTime dt = new DateTime(2024, 08, 20);
        DateTime nowDt = DateTime.Now;

        Console.WriteLine(dt.ToString());
        Console.WriteLine($"Before: {dt.ToString()}\nAdding 45 days: {dt.AddDays(45).ToString()}");
        Console.WriteLine($"Before: {dt.ToString()}\nSubtracting from today's calendar 45 days: {dt.Subtract(nowDt).ToString()}");
        Console.WriteLine($"Is: {dt.ToString()}\nLess than {nowDt.ToString()}: {dt < nowDt}\n");


    }

    static void ex04()
    {
        int i = 10;
        float f = 0;
        f = i; //conversão implícita, sem perda de dados.
        System.Console.WriteLine(f);
        f = 0.5F;
        i = (int)f; //conversão explícita, com perda de dados.
        System.Console.WriteLine(i);


    }

    static void ex05()
    {
        string stringInteiro = "123456789";
        int valorStringInteiro = Convert.ToInt32(stringInteiro);
        Console.WriteLine(valorStringInteiro);
        Int64 valorInt64 = 123456789;
        int valorInt = Convert.ToInt32(valorInt64);
        Console.WriteLine(valorInt);

        //string stringInteiroGrande = "999999999999999999999999999999999999999999999";
        //int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);

    }

    static void ex06()
    {
        string stringInteiro = "123456789";
        int valorStringInteiro;
        bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
        //Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

        string stringInteiroGrande = "999999999999999999999999999999999999999999999";
        int valorStringInteiroGrande;
        bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
        //Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande);

        string stringLetras = "abc";
        double valorStringLetras;
        bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
        //Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);


        string d = (double.MaxValue).ToString();
        float f;
        bool conversion1 = float.TryParse(d, out f);
        Console.WriteLine("Conversão efetuada: " + conversion1 + " Valor: " + f);

        string i = (int.MaxValue).ToString();
        long l;
        bool conversion2 = long.TryParse(i, out l);
        Console.WriteLine("Conversão efetuada: " + conversion2 + " Valor: " + l);

        string b = (byte.MaxValue).ToString();
        uint ui;
        bool conversion3 = uint.TryParse(b, out ui);
        Console.WriteLine("Conversão efetuada: " + conversion3 + " Valor: " + ui);

    }

    static void ex07()
    {
        double valorFracionado = 4.7;
        int valorInteiro1 = (int)valorFracionado;
        int valorInteiro2 = Convert.ToInt32(valorFracionado);
        Console.WriteLine("Conversao explicita = " + valorInteiro1);
        Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);
    }

    static void ex08()
    {
        int x = 10;
        double y = 3.4;
        Console.WriteLine("{0} {1}", x, y);
        Console.WriteLine($"{x} {y}");
        /*
        The first command utilizes “composite formatting” or “indexed placeholders” to print values that are inserted after the string's closing. These values can be explicitly written or can be part of another
        object, such as an array or a list.

        The second command utilizes interpolation to print the values inside curly braces. The interpolation is enables by writing '$' before the string's opening (double quotes)
        */
    }
}
