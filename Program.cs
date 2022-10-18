// Daniel Decoito
// 10-18-22
// Mini Challenge 8 "Guessing game"
// Ask user to guess a number, return if they are above or below and how many tries it took to get right.
// peer reviewd by Mark Ramirez ok so uh definitely an issue the custom game mode only technically goes to 100 because I put 1-1000 and my secret number was over 100 and every time i guessed it would say I'm out of range because of this cause a few other issue's with the text generated when i found the number

bool boolOne = false;
string terminateGame = "Dan is Cool";
bool boolDificulty = true;
string dificultySelect = ".";
int loopCount = 0;
int rangeMax = 10;
int rangeMin = 1;
int secretNumber = 0;
int numCheck;
string userInput;
//--------------------------random----------------------------------
Random randomNumber = new Random();
secretNumber = randomNumber.Next(rangeMin, rangeMax);
//------------------------------bool methood-----------------------------------------------
static bool parseBool(string userInput)
{
    bool result = int.TryParse(userInput, out int numOut) ? result = true : result = false;
    return result;
}
//-----------------------------guess methood--------------------------------------------------------
static string guessMethod(string userInput, int secretNumber)
{
    bool result = int.TryParse(userInput, out int numIntConvert) ? result = true : result = false;
    int guess = result == true ? guess = int.Parse(userInput) : guess = 0;
    string responseText = guess == 0 ? "Invalid input" : guess > secretNumber ? "Your guess is GREATER than the secret number" : "Your guess is LOWER than the secret number";
    return responseText;
}
//-----------------------------------------------------------------------------------------
Console.Clear();
while (terminateGame != "")
{
    while (boolDificulty == true)
    {
        Console.WriteLine("Select dificulty: 1,2,3,4");
        dificultySelect = Console.ReadLine();
        switch (dificultySelect)
        {
            case "1":
                secretNumber = randomNumber.Next(1, 10);
                do
                {
                    Console.WriteLine("the secret number is between 1 and 10");
                    userInput = Console.ReadLine();
                    boolOne = parseBool(userInput);
                    numCheck = boolOne == true ? int.Parse(userInput) : numCheck = 0;
                    Console.WriteLine(guessMethod(userInput, secretNumber));
                    loopCount++;
                    boolDificulty = false;
                } while (secretNumber != numCheck);
                break;
            case "2":
                secretNumber = randomNumber.Next(1, 50);
                do
                {
                    Console.WriteLine("the secret number is between 1 and 50");
                    userInput = Console.ReadLine();
                    boolOne = parseBool(userInput);
                    numCheck = boolOne == true ? int.Parse(userInput) : numCheck = 0;
                    Console.WriteLine(guessMethod(userInput, secretNumber));
                    loopCount++;
                    boolDificulty = false;
                } while (secretNumber != numCheck);
                break;
            case "3":
                secretNumber = randomNumber.Next(1, 100);
                do
                {
                    Console.WriteLine("the secret number is between 1 and 100");
                    userInput = Console.ReadLine();
                    boolOne = parseBool(userInput);
                    numCheck = boolOne == true ? int.Parse(userInput) : numCheck = 0;
                    Console.WriteLine(guessMethod(userInput, secretNumber));
                    loopCount++;
                    boolDificulty = false;
                } while (secretNumber != numCheck);
                break;
            default:
                Console.WriteLine("Incorect input.");
                break;
        }
    }
    Console.Clear();
    boolDificulty = true;
    Console.WriteLine(userInput = loopCount == 1 ? "You guessed it in one try" : $"it took you {loopCount} tries to guess correct");
    Console.WriteLine("\nWould you like to play again?\nEnter any key to play again\nJust press Enter to quit");
    loopCount = 0;
    terminateGame = Console.ReadLine();
}
