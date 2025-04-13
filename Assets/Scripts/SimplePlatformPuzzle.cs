using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlatformPuzzle : MonoBehaviour{
    public GameObject Door;

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            Debug.Log("Works!");
            if (Door.activeInHierarchy){
                Door.SetActive(false);
                SoundManager.Play(SoundType.FINISHED);
            }
        }
    }
}
