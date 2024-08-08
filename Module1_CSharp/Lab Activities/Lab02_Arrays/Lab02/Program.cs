using System.Data;

namespace Lab02;
class Program
{
    static void Main(string[] args)
    {
        //firstExercises();
        //ex01();
        ex02();
    }

    static void firstExercises()
    {
        //2.
        int[] array = new int[5] { 10, 20, 30, 40, 50 };
        int i;
        for (i = 0; i < 5; i++)
        {
            //Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
        }

        //4.
        string[] str = new string[3];
        int iStr;
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Tres";
        for (iStr = 0; iStr < 3; iStr++)
        {
            //Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
        }

        DateTime[] dt = new DateTime[2];
        int iDate;
        dt[0] = new DateTime(2002, 5, 1);
        dt[1] = new DateTime(2002, 6, 1);
        for (iDate = 0; iDate < 2; iDate++)
        {
            //Console.WriteLine("Indice = " + iDate + " & Data = " +
            //dt[iDate].ToShortDateString());
            //ToShortDateString(): 5/1/2002
            //ToString(): 5/1/2002 12:00:00 AM
        }

        //8. Reescrevendo os laços:
        //2.
        int z = 0;
        foreach (int integer in array)
        {
            //Console.WriteLine($"Index {z} and value {integer}");
            z++;
        }

        z = 0;
        foreach (string strin in str)
        {
            //Console.WriteLine($"Index {z} and value {strin}");
            z++;
        }

        z = 0;
        foreach (DateTime dtime in dt)
        {
            Console.WriteLine($"Index {z} and value {dtime.ToShortDateString()}");
            z++;
        }
    }

    static void ex01()
    {
        int[] arr1 = new int[20];
        int[] arr2 = new int[20];

        Random r = new Random();

        //Com laço de repetição
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = r.Next(500);
            //System.Console.WriteLine(arr1[i].ToString().PadLeft(3, ' '));
        }

        //Com método próprio do Array
        Array.Fill<int>(arr2, r.Next(3));

        for (int i = 0; i < arr1.Length; i++)
        {
            System.Console.WriteLine(arr1[i].ToString().PadLeft(3, ' '));
        }

    }

    static void ex02()
    {

        Random r = new Random();

        //Matrix 5x5 two dimensions
        int[,] matrix = new int[5, 5];
        //Jagged Array First initialized with 5 rows and 5 columns
        int[][] jaggedArray = new int[5][] { new int[5], new int[5], new int[5], new int[5], new int[5] };

        //Populate the arrays
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = r.Next(5);
            }
        }

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                jaggedArray[i][j] = r.Next(5);
            }
        }

        //Sum of each array's columns

        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum1 += matrix[i, j];
            }
        }

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                sum2 += jaggedArray[i][j];
            }
        }

        System.Console.WriteLine($"Array 1: {sum1}\nArray 2: {sum2}");

    }
}
