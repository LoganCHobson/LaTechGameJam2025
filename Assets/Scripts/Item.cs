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
    public modes mode;

    private SpriteRenderer spriteRend;

    private void Awake()
    {
        if (guid == Guid.Empty)
        {
            guid = Guid.NewGuid();
        }
    }
    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
       if(mode != modes.None)
        {
            spriteRend.enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
           
            onPickUp.Invoke();
            PickedUp();
        }
    }
    private void Update()
    {
        if ( Game.Instance.render == null)
        {
            Debug.Log("HOW");
        }
        if(mode == Game.Instance.render.mode && !spriteRend.enabled)
        {
            spriteRend.enabled = true;
            if(gameObject.GetComponent<BoxCollider2D>())
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
            
        }
    }

    abstract public void PickedUp();

}
