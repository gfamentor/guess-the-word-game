// Copy this code into your application's Program.cs file
// Write under here code that needs to run before the guessing starts
int totalWrongGuesses = 5;
int currentWrongGuesses = 0;

// All the code needed to process a guess should go in the while loop
while (currentWrongGuesses < totalWrongGuesses) // This loop will execute again and again until this boolean expression is false.
{
    if (true)
    {
        break; // If you would like to exit the loop before the statement above is false, you can use the "break" keyword;
    }
}

// If you want anything to happen after the guessing is over, write it under here.

// Helper Methods
// This method creates the initial word display to print in the terminal
string MakeEmptyWordDisplay(string word)
{
    var output = String.Empty;
    for (int i = 1; i <= word.Length; i++)
    {
        output += "_ ";
    }
    return output;
}

// This method checks if the original word contains the guess
bool WordContains(string word, string guess)
{
    return word.Contains(guess);
}

// When a letter is guessed correctly, you can use this method to update the word display
string UpdateWordDisplay(string word, string guess, string wordDisplay)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (guess.Contains(word[i]))
        {
            wordDisplay = wordDisplay.Remove(i * 2, 1).Insert(i * 2, guess.ToString());
        }
    }
    return wordDisplay;
}