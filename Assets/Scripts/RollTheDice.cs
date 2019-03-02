using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollTheDice : MonoBehaviour
{
    public InputField[] resulsDisplay;
    public int diceSides = 6;
    public int numberOfDiceToRoll = 2;
    public int[] dice;
    //public int playerLoc;


    //private int totalDiceRoll =0;
    



    // Start is called before the first frame update
    void Start()
    {
        dice = new int[numberOfDiceToRoll];
        //player.Loc = (0, 0, 0);

    }
    // roll the dice for both sets of dice, so two different results

    public void RollDice()
    {
        for (int i = 0; i < numberOfDiceToRoll; i++)
        {
            int diceRoll = Random.Range(1, diceSides + 1);
            dice[i] = diceRoll;
           // totalDiceRoll = totalDiceRoll + diceRoll;

            resulsDisplay[i].text = diceRoll.ToString();
        }

       // Debug.Log(totalDiceRoll);
        //rollDiceA.text = diceA.ToString();
        //diceB = Random.Range(1, diceSides+1);
        //rollDiceB.text = diceB.ToString();


    }
    // Move the player in x from the results of both dice added together

    //public PlayerMove()

    //    if (playerLoc == 0)
    //    {
    //    playerLoc.translate.vector3 (diceA + diceB);

    //    }


}