using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye1 : MonoBehaviour{

    public bool isGrabbed = false;
    public GameObject eye;

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            eye.SetActive(false);
            isGrabbed = true;
        }
    }

    

}
