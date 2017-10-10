using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    /// <summary>
    /// Create four new variables all will need to be public
    /// The first two will be of type float and will keep track of the
    /// current score and the other will store the max score the player needs to
    /// win
    /// 
    /// The last two variables will be of type Text and will store a refrence
    /// to the ScoreDisplay UI element and the GameOverDisplay UI element
    /// </summary>
    private float CurrentScore;
    private float MaxScore;

    public Text ScoreDisplay;
    public Text GameOverDisplay;

    /// <summary>
    /// The start function is called by unity when the object is created and is only called once
    /// </summary>
    void Start()
    {
        //Ensure the current score is 0 at the start
        CurrentScore = 0;
        //Set the value of MaxScore by finding all of the PickUp objects in the scene
        MaxScore = GameObject.FindObjectsOfType<PickupBehaviour>().Length;
        //Set the value of the ScoreDisplay text to the value of Current score
        ScoreDisplay.text = CurrentScore.ToString();                
    }

    /// <summary>
    /// Gets invoke with a pickup object is hit
    /// </summary>
    public void UpdateScore()
    {
        //Increments the value of CurrentScore by 1
        CurrentScore++;
        //Update the ScoreDisplay
        ScoreDisplay.text = CurrentScore.ToString();
        //If current score is greater than of equal to the MaxScore
        if (CurrentScore == MaxScore)
        {
            //turn on the GameOverDisplay
            GameOverDisplay.text = "Game Over";
        }
    }    
}
