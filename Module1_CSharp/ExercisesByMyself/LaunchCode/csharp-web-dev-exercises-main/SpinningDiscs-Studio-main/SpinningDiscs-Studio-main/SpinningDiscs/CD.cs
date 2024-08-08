using System;

namespace SpinningDiscs
{
    public class CD : Spinnable, ISpinnable
    {
        private string audioContent;
        public string AudioContent { get { return audioContent; } set { audioContent = value; } }
        public CD(double sv, double dr, string t, string ac) : base(sv, dr, t)
        {
            audioContent = ac;
        }

        public void SpinDisc()
        {
            System.Console.WriteLine($"Spinning a CD disc at {SpinVelocity} velocity!");
        }

        public string ReportInformation()
        {
            return $"I am a CD with {SpinVelocity} spin velocity, {DiscRadius} disc radius and {Title} as my title!";
        }

        public string ReadData()
        {
            return "The current data is the content: " + audioContent;
        }

        public void StoreData(string d)
        {
            if (audioContent.Equals("Empty"))
            {
                audioContent = d;
                System.Console.WriteLine("New audio content: " + audioContent);
            }
            else
            {
                System.Console.WriteLine("Please play content before storing new data! Current data: " + audioContent);
            }
        }

        public void playContent()
        {
            if (!audioContent.Equals("Empty"))
            {
                System.Console.WriteLine("Now playing: " + audioContent);
                audioContent = "Empty";
            }
            else
            {
                System.Console.WriteLine("Please store data before playing new content! Current data: " + audioContent);
            }
        }

        public void extractData()
        {
            if (!audioContent.Equals("Empty"))
            {
                System.Console.WriteLine("Extracting: " + audioContent);
                Data.Add(audioContent);
                audioContent = "Empty";
                Data.ForEach(element => Console.Write(element + ", "));
            }
            else
            {
                System.Console.WriteLine("Please store data before extracting content! Current data: " + audioContent);
            }
            System.Console.WriteLine();
        }

    }
}

