////Mini project - 
////Create an application where the computer randomly selects a number between 1 and 100 and the player has to guess the number. The game should:
////Provide feedback on if the guess is too high, too low, or correct
////The game should continue until the player guesses the correct number
////The player should be able to choose to play again after guessing correctly or leave the game
////Create a method to generate the random number
////Create a method for handling the game logic for 1 round
////Prompt the player to enter their guess and convert it to an integer (account for validation)
////Bonus** Keep track of the number of attempts the player has made in a round
////Bonus** When the player guesses the correct number, display an additional unique message congratulating them and display the number of attempts it took

//Console.WriteLine("This is the GuessThatNumber Game!!!" +
//    "Where you have to guess the random number 1 - 100!");
//Console.WriteLine("whats your first guess");
//int userInput1 = Convert.ToInt32(Console.ReadLine());
//int correctNumber= 0;
////new RandomCount() = new RandomCount1();
//while (userInput1 != correctNumber)
//{
//    Console.WriteLine("sorry that is not the right guess");
//    if (userInput1 > correctNumber)
//    {
//        Console.WriteLine("Sorry that guess is too low");
//        TooHighTooLow();
//    }
//    if (userInput1 > correctNumber)
//    {
//        Console.WriteLine("Sorry that guess is too high");
//        return;
//    }
//    else
//    {
//        Console.WriteLine( "Input must be 1 - 100");
//    }
//}
//bool isCorrect = true;
//bool isUserInputValid = false;

//static int GenerateNummber(bool isUserInputValid)
//{
//    Random computerNumber = new Random();
//    if (isUserInputValid)
//    {
//        return computerNumber.Next(1, 100);
//    }
//    else
//    {
//        return TooHighTooLow();
//    }


//}

// static int TooHighTooLow()
//{
//    Console.WriteLine("Alrighty, what is your next guess?");
//    if (isUserInputValid)
//    {
//        Console.WriteLine("sorry input must be between 1-100");
//        return TooHighTooLow();
//    }
//    else
//    {
//        isUserInputValid = true;
//    }


//    int computerNumber;
//    string userInput = Console.ReadLine();
//    bool isUserNumber = int.TryParse(userInput, out int userGuess);

//    if (userGuess <= computerNumber)
//    {
//        Console.WriteLine("Congradulations, thats the right answer! Truely a 1 in 100 guess");
//        return PlayAgain();

//    }
//    if (userGuess < computerNumber)
//    {
//        Console.WriteLine("good guess but guess again, that guess was too low");
//        return;
//    }
//    else if (userGuess > computerNumber)
//    {
//        Console.WriteLine("good guess but guess again, that guess was too high");
//        return;
//    }

//    return;
//}

// static string PlayAgain()
//{
//    Console.WriteLine("Would you like to play again?");
//    string userPlayAgain = Console.ReadLine().ToLower();
//    if (userPlayAgain == "yes")
//    {
//        break;
//    }
//    else if (userPlayAgain == "no")
//    {
//        return Exit();
//    }
//    else
//    {
//        Console.WriteLine("input must be yes or no");
//        return;
//    }
//}

// int GuessCount(int userAttempts)
//{
//    //code tracking the # of guess till correct answer
//    if (isCorrect)
//    {
//        Console.WriteLine($"You guessed {userAttempts} times and got it!");
//        return Home();
//    }
//    else
//    {
//        userAttempts += 1;
//        return Home();
//    }
//}


//Mini project - 
//Create an application where the computer randomly selects a number between 1 and 100 and the player has to guess the number. The game should:
//Provide feedback on if the guess is too high, too low, or correct
//The game should continue until the player guesses the correct number
//The player should be able to choose to play again after guessing correctly or leave the game
//Create a method to generate the random number
//Create a method for handling the game logic for 1 round
//Prompt the player to enter their guess and convert it to an integer (account for validation)
//Bonus** Keep track of the number of attempts the player has made in a round
//Bonus** When the player guesses the correct number, display an additional unique message congratulating them and display the number of attempts it took


Console.WriteLine("pick a number");

int userInput = Convert.ToInt32(Console.ReadLine());
int correctNumber = RandoGen();
List<int> guessCount = new List<int>();
//ARound(/*userInput*/);


//while (userInput = isWrong)
//{
//    if (userInput > correctNumber)
//    {
//        Console.WriteLine("that guess is ");
//    }
//}


//Console.WriteLine("Way to go you guessed the right number!");
//Console.WriteLine($"That only took you {guessCount.} guesses!");
//if (ARound()= t)
//bool ARound(/*userInput*/)
//{
//    Welcome, play my game.
//        whats ur guess? userInput?
//        if userInput is wrong is it too high or too low?, go again.

while (userInput != correctNumber) // while the userinput is not the right number
{
    if (userInput < correctNumber)// if the input is lower then the right number
    {
        Console.WriteLine("number is too low");
        guessCount.Add(1);
        return; // bool
    }

    else if (userInput > correctNumber)// if the input is higher then the right number
    {
        Console.WriteLine("number is too high");
        guessCount.Add(1);
        return;
    }
    else
    {

        Console.WriteLine("Input needs to be a number 1-100"); // if the input is outside the 100 criteria
        return;
    }

}

// needs to return true or false.
//}
int RandoGen() // random num Gen
{
    Random Game = new Random();
    int correctNumber = Game.Next(1, 101);
    return correctNumber;
}



while (userInput != correctNumber)
{
    Console.WriteLine("thats not quite it");

    while (userInput > correctNumber)
    {
        Console.WriteLine("its too high");
        Console.WriteLine("guess again");
        int userInput1 = Convert.ToInt32(Console.ReadLine());
        //if (userInput1 = correctNumber)
        //{
        //    Console.WriteLine("way to go! you did it!");

        //}
        //else
        //{
        //    return;
        //}
    }


    Console.WriteLine("its too low");
}
Console.WriteLine("Congrats thats the right number");
