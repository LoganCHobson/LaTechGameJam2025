using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
   public GameObject eventGrab;

   public void PressGreen(){
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Green);
   }
}
