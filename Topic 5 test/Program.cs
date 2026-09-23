namespace Topic_5_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("What is your grade?");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade < 50)
                Console.WriteLine("This is an F!");
            if (grade <= 65)
            Console.WriteLine("This is an D");
            if (grade <= 75)
                Console.WriteLine("This is a C!");
            if (grade <= 85)
                Console.WriteLine("This is a B");
            if (grade > 85)
                Console.WriteLine("This is an A");
        }
    }
}
