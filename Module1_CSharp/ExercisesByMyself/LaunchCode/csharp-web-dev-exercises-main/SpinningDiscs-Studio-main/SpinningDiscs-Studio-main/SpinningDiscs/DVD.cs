using System;

namespace SpinningDiscs
{
    public class DVD : Spinnable, ISpinnable
    {
        private string universalContent;
        public string UniversalContent { get { return universalContent; } set { universalContent = value; } }
        public DVD(double sv, double dr, string t, string uc) : base(sv, dr, t)
        {
            universalContent = uc;
        }

        public void SpinDisc()
        {
            System.Console.WriteLine($"Spinning a DVD disc at {SpinVelocity} velocity!");
        }

        public string ReportInformation()
        {
            return $"I am a DVD with {SpinVelocity} spin velocity, {DiscRadius} disc radius and {Title} as my title!";
        }

        public string ReadData()
        {
            return "The current data is the content: " + universalContent;
        }

        public void StoreData(string d)
        {
            if (universalContent.Equals("Empty"))
            {
                universalContent = d;
                System.Console.WriteLine("New universal content: " + universalContent);
            }
            else
            {
                System.Console.WriteLine("Please play content before storing new data! Current data: " + universalContent);
            }
        }

        public void playContent()
        {
            if (!universalContent.Equals("Empty"))
            {
                System.Console.WriteLine("Now playing: " + universalContent);
                universalContent = "Empty";
            }
            else
            {
                System.Console.WriteLine("Please store data before playing new content! Current data: " + universalContent);
            }
        }

        public void extractData()
        {
            if (!universalContent.Equals("Empty"))
            {
                System.Console.WriteLine("Extracting: " + universalContent);
                Data.Add(universalContent);
                universalContent = "Empty";
                Data.ForEach(element => Console.Write(element + ", "));
            }
            else
            {
                System.Console.WriteLine("Please store data before extracting content! Current data: " + universalContent);
            }
            System.Console.WriteLine();
        }

    }
}


