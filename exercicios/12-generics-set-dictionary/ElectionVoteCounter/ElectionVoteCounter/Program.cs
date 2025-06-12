namespace ElectionVoteCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] data = sr.ReadLine().Split(',');
                        string name = data[0];
                        int votes = int.Parse(data[1]);

                        if (result.ContainsKey(name))
                        {
                            result[name] += votes;
                        }
                        else
                        {
                            result[name] = votes;
                        }
                    }

                    foreach (var candidate in result)
                    {
                        Console.WriteLine($"{candidate.Key} : {candidate.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
