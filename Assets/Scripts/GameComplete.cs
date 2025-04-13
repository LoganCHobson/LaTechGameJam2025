using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{  
    public RenderManager render;
    // Start is called before the first frame update
    void Start()
    {
        render.ChangeRenderFeature(modes.None);   
    }

public void OnClick(){
    
}
}
