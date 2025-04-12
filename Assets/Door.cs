using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject destinationDoor;
    public Transform spawnpoint;




    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 2);


        if (hit.collider.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                //Play animation code or whatever.

                hit.collider.gameObject.gameObject.transform.root.position = destinationDoor.GetComponent<Door>().spawnpoint.position;
            }

        }
    }


}

        

