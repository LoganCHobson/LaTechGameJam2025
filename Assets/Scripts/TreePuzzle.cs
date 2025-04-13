using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class TreePuzzle : MonoBehaviour
{
    Queue correct = new Queue(3);
    Queue Entered = new Queue(3);
    public GameObject[] buttons = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        correct.Enqueue(2); 
        correct.Enqueue(3);
        correct.Enqueue(1);

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(2, 2), 0, Vector2.down, 2);

        if (hit.collider.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
            }
            
        }
    }
}
