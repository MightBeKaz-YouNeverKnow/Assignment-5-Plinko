using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public int points = 1;
    
    public Player player;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Add to score 
        scoreKeeper.AddScore(points);
        //Destroy the object
        Destroy(collider.gameObject);
      
        //if Fish mode is active, double the points
       if (collider.gameObject.CompareTag("Fish"))
       {
           scoreKeeper.AddScore(points *2);
        }

    }
}
