using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPlatform : MonoBehaviour{
    public Platforms platform;
    void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            Debug.Log("Works!");
            if (!PlatformPuzzle.puzzleComplete){
                Debug.Log("Pressed this one: " + platform);
                PlatformPuzzle.Press(platform);
            }
        }
    }
}
