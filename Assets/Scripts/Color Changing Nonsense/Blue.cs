using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    public GameObject eventGrab;

   public void PressBlue(){
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Blue);
   }
}
