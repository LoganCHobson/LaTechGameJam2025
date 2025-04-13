using System;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public string message;
    public bool onEnter;

    public Helper helper;
    public GameObject eye;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(2, 2), 0, Vector2.down, 2);

        if (hit.collider.gameObject.tag.Equals("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Tab) && !onEnter)
            {
                DialogController.Instance.Dialog(message);
            }
            else if(onEnter)
            {
                helper.Execute(message, eye);
            }
        }
    }
}

abstract public class Helper : MonoBehaviour {
    public abstract void Execute(string message, GameObject obj);
  

    
}





