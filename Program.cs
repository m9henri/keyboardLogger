namespace keyboardLogger;

class Program
{
    static void Main(string[] args)
    {
        string filename = "input.log";

        if (!File.Exists(filename)) // failsafe
        {
            File.Create(filename).Close();
        }

        while(true)
        {
            string key = Console.ReadKey(true).Key.ToString();
            File.AppendAllText(filename, key);
        }
    }
}
