namespace DormRoomManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nRent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                students[roomNumber] = new Student(name, email);
            }

            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                    Console.WriteLine($"{i}: " + students[i]);
            }
        }
    }
}
