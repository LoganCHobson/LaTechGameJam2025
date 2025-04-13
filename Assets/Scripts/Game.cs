using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    public GameObject mainMenuScreen;
    public GameObject gameOverlay;
    public GameObject eventGrab;

    public static Game Instance;

    void Start(){

        Instance = this;
    }
    public void StartGame(){
        mainMenuScreen.SetActive(false);
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Grey);
    }

}
