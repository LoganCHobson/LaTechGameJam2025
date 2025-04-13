using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeGrab : MonoBehaviour {
    public modes colors;
    public GameObject eyeBall;
    public GameObject ui;
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject redBlue;
    public GameObject redGreen;
    public GameObject greenBlue;

    // private void Start(){
    //     ui.SetActive(false);
    //     redBlue.SetActive(false);
    //     redGreen.SetActive(false);
    //     greenBlue.SetActive(false); 
    // }
    void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            Debug.Log("Collected an eye! " + colors);
            Debug.Log(eyeBall);
            

            ui.SetActive(true);
            Debug.Log("Ui is "+ ui);
            Debug.Log(ui.activeInHierarchy);

            SoundManager.Play(SoundType.GRABBED);

            if (red.activeInHierarchy && blue.activeInHierarchy){
                redBlue.SetActive(true);
            }
            if (green.activeInHierarchy && blue.activeInHierarchy){
                greenBlue.SetActive(true);
            }
            if (red.activeInHierarchy && green.activeInHierarchy){
                redGreen.SetActive(true);
            }
            if (red.activeInHierarchy && green.activeInHierarchy && blue.activeInHierarchy){
                Game.GameComplete();
            }
            eyeBall.SetActive(false);
        }
    }
}

