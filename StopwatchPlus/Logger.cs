using System.IO;


namespace StopwatchPlus
{
    public class Logger
    {
        const string FullPath = @"C:\C#\StopwatchProject\Logs\PersonAdded.txt";

        public void Log(string firstName, string lastName, string date)
        {
            using (StreamWriter streamWriter = new StreamWriter(FullPath, true))
            {
                streamWriter.WriteLine($"{firstName} {lastName} was added on {date}");
            }

        }
    }
}
