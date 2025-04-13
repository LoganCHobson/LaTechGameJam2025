using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGreen : MonoBehaviour
{
    public GameObject eventGrab;

   public void PressRedGreen(){
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.RedGreen);
   }
}
