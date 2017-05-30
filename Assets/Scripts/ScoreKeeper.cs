using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public float CurrentScore;
    public float MaxScore;



    void UpdateScore()
    {
        CurrentScore++;
        if (CurrentScore >= MaxScore)
        {
            
        }
    }    
}
