using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public GameObject destinationDoor;
    public Transform spawnpoint;

    public bool unlocked = true;

    public Key key;


    public UnityEvent openDoor;
    public UnityEvent closeDoor;
    public UnityEvent lockedDoor;

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
                    lockedDoor.Invoke();
                    DialogController.Instance.Dialog("Door is locked! Find the Key!");
                }
                else
                {
                    if (!unlocked)
                    {
                        Inventory.Instance.RemoveItem(key);
                        unlocked = true;
                    }
                    openDoor.Invoke();
                    player.transform.root.position = destinationDoor.GetComponent<Door>().spawnpoint.position;
                }
                //Play animation code or whatever.


            }

        }
    }

    public void OnCloseDoor()
    {
        closeDoor.Invoke();
    }



}
