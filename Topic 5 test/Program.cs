namespace Topic_5_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money;
            string working;

            Console.WriteLine("Hello, welcome to the movie theatres.");
            Console.WriteLine("Are you working today? (Yes/No)");
            working = Console.ReadLine().ToLower();
            Console.WriteLine("How much money do you have?");
            double.TryParse(Console.ReadLine(), out money);
            if (money >= 20.00 && working == "no")
                Console.WriteLine("Perfect you have " + money.ToString("C") + " and you don't have work");
            Console.WriteLine("Would you like to spend your " + money.ToString("C") + "for a seat that costs $24");
            else
                Console.WriteLine("You don't reach the requirements, sorry...");

            
        }
    }
}
