using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject destinationDoor;
    public Transform spawnpoint;




    private void Update()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(2,2), 0, Vector2.down, 2);


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

        

