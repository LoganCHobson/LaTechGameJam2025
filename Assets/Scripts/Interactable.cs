using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public string message;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(2, 2), 0, Vector2.down, 2);

        if (hit.collider.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                DialogController.Instance.Dialog(message);
            }
        }
    }
}
