using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBlue : MonoBehaviour
{
    public GameObject eventGrab;

   public void PressGreenBlue(){
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.GreenBlue);
   }
}
