using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour
{
    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int usersGuess;

    // Start is called before the first frame update
    void Start()
    {
        guessNumber = Random.Range(0, 100);
    }

    public void CheckGuess()
    {
        usersGuess = int.Parse(input.text);

        if (usersGuess == guessNumber)
        {
            infoText.text = "You Guessed the Number!";
        }
        else if (usersGuess > guessNumber)
        {
            infoText.text = "You went to high";
        }
        else if (usersGuess < guessNumber)
        {
            infoText.text = "You Guessed too low!";
        }

        input.text = "";
    }
}
