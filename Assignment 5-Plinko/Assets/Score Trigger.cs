using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
   public ScoreKeeper scoreKeeper;
    public int ponits = 1;
    private void OnTriggerEnter2D(Collider2D collider)
    {
       //Add to score 
       scoreKeeper.AddScore(ponits);
        //Destroy the object
        Destroy(collider.gameObject);
    }
}
