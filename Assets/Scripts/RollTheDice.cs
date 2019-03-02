using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollTheDice : MonoBehaviour
{ 
public InputField rollDiceA;
public InputField rollDiceB;
public Text resultOutA;
public Text resultOutB;
//public int playerLoc;


private int diceA;
private int diceB;
   


    // Start is called before the first frame update
    void Start()
    {
        diceA = 0;
        diceB = 0;
        //player.Loc = (0, 0, 0);

    }
    // roll the dice for both sets of dice, so two different results

    public void RollDice()
    {
        diceA = Random.Range(0, 5);
        rollDiceA.text = diceA.ToString();
        diceB = Random.Range(0, 5);
        rollDiceB.text = diceB.ToString();


    }
    // Move the player in x from the results of both dice added together

    //public PlayerMove()

    //    if (playerLoc == 0)
    //    {
    //    playerLoc.translate.vector3 (diceA + diceB);
        
    //    }


}