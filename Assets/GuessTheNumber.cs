using TMPro;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField inputField;
    int number = 0;
    int numberOfGuesses = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeHeader(string text)
    {
        header.text = text;
    }

    public void GameSetup()
    {

        // Choose the random number that the player must guess (1-10)
        number = Random.Range(1, 11);
        //Debug.Log(number);

        // Update guesses 
        numberOfGuesses = 3;

        // Update the header text 
        ChangeHeader("Please guess a number between 1 and 10.  You have 3 attempts to guess..");

        // Clear the text in the input field
        inputField.text = "";

    }

    public void SubmitGuess()
    {
        // Store user input
        int input;

        if (!int.TryParse(inputField.text, out input))
        {
            header.text = "Invalid input!";
            return;
        }
        // Lower remaining attempts
        numberOfGuesses = numberOfGuesses - 1;

        // Update header text if right
        if (input == number)
        {
            header.text = "You won!";
        }
        // Update header text if wrong
        else if (numberOfGuesses > 0)
        {
            // Display try again
            header.text = "Try again! " + numberOfGuesses.ToString() + " guesses remaining";
        }
        // If guess incorrect and guesses depleted
        else
        {
            header.text = "Game Over!";
        }
    }

}
