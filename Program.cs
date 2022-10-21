namespace CountriesMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {
                CountryController cc = new CountryController();
                cc.WelcomeAction();
            }
            goOn = GoAgain();
        }

        public static bool GoAgain()
        {
            Console.WriteLine("\nWould you like to check another country? Y/N\n");
            string input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                Console.WriteLine("\nOkay, great!");
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("\nGoodbye");
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't catch that.");
                return GoAgain();
            }

        }
    }
}