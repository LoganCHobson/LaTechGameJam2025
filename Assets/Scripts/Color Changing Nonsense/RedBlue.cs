using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlue : MonoBehaviour
{
    public GameObject eventGrab;

   public void PressRedBlue(){
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.RedBlue);
   }
}
