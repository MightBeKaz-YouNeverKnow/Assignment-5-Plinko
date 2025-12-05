using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject Disk;
    public GameObject Fish;
    public CameraFollow cameraFollow;
    private GameObject activeDisk;
    public bool isInFishMode = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DropDisk();
        
    }

    void DropDisk()
    {
        if (Input.GetButtonDown("Fire1") && activeDisk == null)
        {
            
            if (isInFishMode == true)
            {
                Vector3 position = transform.position;
                Quaternion rotation = transform.rotation;
                Instantiate(Fish, position, rotation);
                isInFishMode = false;
            }
            else
            {
                Vector3 position = transform.position;
                Quaternion rotation = transform.rotation;
                activeDisk = Instantiate(Disk, position, rotation);
                cameraFollow.FollowDisk(activeDisk);
            }
        }
        
    }
    void Move()
    {
        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }
   public void FishMode()
    { 
       isInFishMode = true;






    }

}

