namespace CourseEnrollmentAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = [];
            HashSet<int> courseB = [];
            HashSet<int> courseC = [];

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }

            HashSet<int> students = new HashSet<int>(courseA);
            students.UnionWith(courseB);
            students.UnionWith(courseC);

            Console.WriteLine("Total students: " + students.Count);
        }
    }
}
