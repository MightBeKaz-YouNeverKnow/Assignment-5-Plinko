using UnityEngine;
using UnityEngine.UIElements;


public class CameraFollow : MonoBehaviour
{
    
    public new Camera camera;
    public GameObject player;
    public GameObject disk;
    public GameObject fish;
    public float lerpRate = 0.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3  targetPosition;
        if (disk == null)
        {
            targetPosition = player.transform.position;
        }
        else
        {
            targetPosition = disk.transform.position;
        }
       
        targetPosition.y = camera.transform.position.y;
        targetPosition.z = camera.transform.position.z;
        
        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, lerpRate);

    }


        public void FollowDisk(GameObject disk)
        {
            this.disk = disk;
    
        }
        public void FollowFish()
        {
            this.disk = null;
        
        }
}

