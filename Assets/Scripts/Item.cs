using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
abstract public class Item : MonoBehaviour
{
    public Guid guid = Guid.NewGuid();
    public GameObject gfx;

    [HideInInspector]
    public GameObject inventoryGfx; //Don't access this 

    public UnityEvent onPickUp;


    private void Awake()
    {
        if (guid == Guid.Empty)
        {
            guid = Guid.NewGuid();
        }
    }
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
           
            onPickUp.Invoke();
            PickedUp();
        }
    }

    abstract public void PickedUp();

}
