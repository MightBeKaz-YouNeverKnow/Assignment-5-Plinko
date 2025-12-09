using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public int score = 0;
    public void AddScore (int points)
    {
        score += points;
        scoreDisplay.text = $"SCORE: {score, 000000000000000000}";
    }
    public void UpdateScoreDisplay ()
    { 
        scoreDisplay.text = $"SCORE: {score}";
    }
  
    

}
