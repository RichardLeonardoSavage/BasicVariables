namespace BasicVariables
{
    class Program
    { 
        static void Main(string[] args)
        {
            string characterName = "Richard";
            int characterAge = 23;
            string characterLocation = "Christchurch";
            char favouriteLetter = 'A';
            
            Console.WriteLine(characterName + " is from " + characterLocation + " and is " + characterAge + " and his favourite letter is " + favouriteLetter);

            Console.WriteLine("Every year " + characterName + " leaves his home of " + characterLocation + " to find things that start with the letter " + favouriteLetter);

            Console.ReadLine();


        }
    }
}
