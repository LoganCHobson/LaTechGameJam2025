using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour{
   public GameObject eventGrab;

   public void PressRed(){
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Red);
   }
}
