using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye1 : MonoBehaviour{

    public static bool isGrabbed = false;
    public GameObject eye;

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            Debug.Log("ceye 1 grabbed");
            eye.SetActive(false);
            isGrabbed = true;
        }
    }

    public static void clearGrab(){
        isGrabbed = false;
    }

}