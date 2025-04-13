using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    public GameObject mainMenuScreen;
    public GameObject gameOverlay;
    public GameObject pauseMenu;
    public GameObject eventGrab;

    public static Game Instance;
    public GameObject Red;
    public GameObject Blue;
    public GameObject Green;
    public GameObject RedBlue;
    public GameObject RedGreen;
    public GameObject GreenBlue;
    

    void Start(){
        mainMenuScreen.SetActive(true);
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Grey);
        Instance = this;
        Red.SetActive(false);
        Green.SetActive(false);
        Blue.SetActive(false);
        RedBlue.SetActive(false);
        RedGreen.SetActive(false);
        GreenBlue.SetActive(false);
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
    public static void GameComplete(){
        Debug.Log("You did it!");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            PauseGame();
        }
        if(Input.GetKey(KeyCode.Alpha1) && Red.activeInHierarchy){
            eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Red);
        }
        if(Input.GetKey(KeyCode.Alpha2) && Green.activeInHierarchy){
            eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Green);
        }
        if(Input.GetKey(KeyCode.Alpha3) && Blue.activeInHierarchy){
            eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Blue);
        }
        if(Input.GetKey(KeyCode.Alpha4) && RedGreen.activeInHierarchy){
            eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.RedGreen);
        }
        if(Input.GetKey(KeyCode.Alpha5) && RedBlue.activeInHierarchy){
            eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.RedBlue);
        }
        if(Input.GetKey(KeyCode.Alpha6) && GreenBlue.activeInHierarchy){
            eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.GreenBlue);
        }
    }

}
