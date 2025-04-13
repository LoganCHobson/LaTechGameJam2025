using System;
using System.Collections.Generic;
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



    public List<SpriteRenderer> spriteRends;



    bool collected;
    private void Awake()
    {
        if (guid == Guid.Empty)
        {
            guid = Guid.NewGuid();
        }
    }
    void Start()
    {


        if (mode != modes.None)
        {
            foreach (SpriteRenderer spriteRend in spriteRends)
            {

                spriteRend.enabled = false;

            }


            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collected = true;
            onPickUp.Invoke();
            PickedUp();
        }
    }
    private void Update()
    {
        if (Game.Instance.render == null)
        {
            Debug.Log("HOW");
        }
        if (mode == Game.Instance.render.mode)
        {
            if (!CheckRends() && !collected)
            {


                foreach (SpriteRenderer spriteRend in spriteRends)
                {

                    spriteRend.enabled = true;

                }
                if (gameObject.GetComponent<BoxCollider2D>())
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
        }

        else
        {


            if (mode != modes.None && CheckRends() == true && !collected)
            {
                foreach (SpriteRenderer spriteRend in spriteRends)
                {

                    spriteRend.enabled = false;

                }
                if (gameObject.GetComponent<BoxCollider2D>())
                {
                    gameObject.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }

    }

    private bool CheckRends()
    {
        int i = 0;
        foreach (SpriteRenderer spriteRend in spriteRends)
        {

            if (spriteRend.enabled)
            {
                i++;
            }


        }
        if (i > 0)
        {
            Debug.Log("Nah");
            return true;
        }
        else
        {
            Debug.Log("Yah");
            return false;
        }

    }

    abstract public void PickedUp();

}
