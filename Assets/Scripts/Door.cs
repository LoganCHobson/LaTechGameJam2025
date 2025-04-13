using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject destinationDoor;
    public Transform spawnpoint;

    public bool unlocked = true;

    public Key key;

    private void Update()
    {

        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(2, 2), 0, Vector2.down, 2);


        if (hit.collider.gameObject.CompareTag("Player"))
        {
            GameObject player = hit.collider.gameObject;
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                
                if (!unlocked && Inventory.Instance.FindItem(key.guid) == null)
                {
                    DialogController.Instance.Dialog("Door is locked! Find the Key!");
                }
                else
                {
                    if (!unlocked)
                    {
                        Inventory.Instance.RemoveItem(key);
                        unlocked = true;
                    }
                    player.transform.root.position = destinationDoor.GetComponent<Door>().spawnpoint.position;
                }
                //Play animation code or whatever.


            }

        }
    }



}
