namespace Topic_5_test
{
    internal class Program

    {

        static void Typer(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);

                Thread.Sleep(20);
            }
            Console.WriteLine();
        }



        static void Main(string[] args)

        {
            

            //double money;
            //string working;
            //Typer("Hello, welcome to the movie theatres.");
            ////Console.WriteLine("Hello, welcome to the movie theatres.");
            //Console.WriteLine("Are you working today? (Yes/No)");
            //working = Console.ReadLine().ToLower();
            //Console.WriteLine("How much money do you have?");
            //double.TryParse(Console.ReadLine(), out money);
            //if (money >= 20.00 && working == "no")
            //    Console.WriteLine("Perfect you have " + money.ToString("C") + " and you don't have work, you can go to the movie");
            //else
            //    Console.WriteLine("You don't reach the requirements, sorry...");
            //Console.ReadLine();
            //Console.Clear();


            //string password;
            //int guesses;

            //Console.WriteLine("Please answer the password. (Hint: 5 letters)");
            //password = Console.ReadLine();
            //Console.WriteLine("How many guesses did you take. (Santa)");
            //guesses = Convert.ToInt32(Console.ReadLine());
            //if (guesses < 5 && password == "santa")
            //    Console.WriteLine("Open seseme");
            //else
            //    Console.WriteLine("Access denied");


            //int age;

            //Console.WriteLine("Hello, welcome aboard to my bus.");
            //Console.WriteLine("Before you purchase can you tell me how old you are?");
            //int.TryParse(Console.ReadLine(), out age);
            //if (age >= 60 || age <= 12)
            //    Console.WriteLine("You will have to pay $2.00");
            //else
            //    Console.WriteLine("You will have to pay $3.50");


            //string favAnimal;
            //Console.WriteLine("What is your favourite animal, cat or dog?");
            //favAnimal = Console.ReadLine();
            //if (favAnimal == "cat" || favAnimal == "dog")
            //    Console.WriteLine("Me too!");
            //else
            //    Console.WriteLine("To each their own...");


            //string weather;
            //int temp;

            //Console.WriteLine("What is the temperature today?");
            //int.TryParse(Console.ReadLine(), out temp);
            //Console.WriteLine("What is the weather looking like today?");
            //weather = Console.ReadLine();
            //if (temp >= 25 || weather == "Sunny" || weather == "Cloudy")
            //    Console.WriteLine("Swim time!");
            //else
            //    Console.WriteLine("Nap time!");


            int personOne, personTwo, personThree;

            // Input three ages ensuring data validity

            Console.WriteLine("Please enter the age of Person 1:");
            while (!Int32.TryParse(Console.ReadLine(), out personOne))
                Console.WriteLine("Please enter a valid age");



            Console.WriteLine();
            Console.WriteLine("Please enter the age of Person 2:");
            while (!Int32.TryParse(Console.ReadLine(), out personTwo))
                Console.WriteLine("Please enter a valid age");



            Console.WriteLine();
            Console.WriteLine("Please enter the age of Person 3:");
            while (!Int32.TryParse(Console.ReadLine(), out personThree))
                Console.WriteLine("Please enter a valid age");

            if (personOne >= personThree) 
                Console.WriteLine("Person 1 is older than person 2")
            if (personThree >= personThree)


        }
    }
}
