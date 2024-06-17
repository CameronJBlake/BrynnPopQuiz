PlayGame(UserGuess)
PlayAgain();

int NumberGen()
{
    Random gameNumber = new Random();
    int numToGuess = gameNumber.Next(1, 101);
    return numToGuess;
}
bool PlayAgain()
{

    do
    {
        Console.WriteLine("Hello this is our number guessing game.");
        Console.WriteLine("You need to guess a number 1-100");
        string userInput= Console.ReadLine();
        bool guess = int.TryParse(userInput, out int userGuess);
        
        int numToGuess = 0;

        

        if (guess)
        {
            if (userGuess > 0 && userGuess < 101)
            {
                if (userGuess > numToGuess)
                {
                    Console.WriteLine("that number is too high, guess again");
                }
                if (userGuess < numToGuess)
                {
                    Console.WriteLine("That number is too low, guess again!");
                }
                else
                {
                    Console.WriteLine("way to go! you got the right number!");
                    Console.WriteLine("would you like to play again?");
                    string playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "y")
                    {
                        return PlayAgain();
                    }
                    else
                    {
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("sorry input needs to be a number between 1- 100 try again");
            }

        }
        else
        {
            Console.WriteLine("sorry input needs to be a number.");
        }

    } while (PlayAgain(true));
}
void GoAgain()
{
    Console.WriteLine("Would you like to play again?");
    string UserChoice = Console.ReadLine().ToLower();

    do
    {
        if (UserChoice == "no" || "n")
        {
            break;
        }
        int GenerateNum = NumberGen();
        // int number of guesses; 
        int Guess;
        PlayAgain(Guess);


    }
    while (UserChoice == "yes");

    Console.WriteLine("Thank for playing, Goodbye");
}