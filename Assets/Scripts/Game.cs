using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    public GameObject mainMenuScreen;
    public GameObject gameOverlay;
    public GameObject pauseMenu;
    public GameObject eventGrab;

    public static Game Instance;

    void Start(){
        mainMenuScreen.SetActive(true);
        Instance = this;
    }
    public void StartGame(){
        mainMenuScreen.SetActive(false);
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Grey);
    }
    public void PauseGame(){
        if (pauseMenu.activeInHierarchy){
                pauseMenu.SetActive(false);
            }
        else{
            pauseMenu.SetActive(true);
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            PauseGame();
        }
    }

}
