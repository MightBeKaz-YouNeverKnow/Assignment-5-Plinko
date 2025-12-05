using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class FishTrigger : MonoBehaviour
{
    
    public Player player;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        player.FishMode();


        //Destroy the object
        Destroy(collider.gameObject);
        

    }
    

}
