using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour{
    modes colors;
    public GameObject redButton;
    public GameObject greenButton;
    public GameObject blueButton;
    public GameObject redBlueButton;
    public GameObject redGreenButton;
    public GameObject greenBlueButton;
    private GameObject eventGrab;

    public void ChangeColor(){

        Debug.Log("Fuck ya life bing bong ");
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(colors);
    }
}
