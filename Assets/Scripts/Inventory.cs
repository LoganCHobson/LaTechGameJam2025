using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<Guid, Item> items = new Dictionary<Guid, Item>();
    public GameObject inventoryVisual;


    public static Inventory Instance;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void AddItem(Item item)
    {
        if (items.ContainsKey(item.guid))
        {
            item.guid = Guid.NewGuid();
        }
        items.Add(item.guid, item);
        Debug.Log("Added Item");

        UpdateVisual();
        Debug.Log(items.Count.ToString());
    }

    public void RemoveItem(Item item)
    {
        Destroy(item.inventoryGfx); //Removes it out of the UI
        items.Remove(item.guid); //Removes it out of the collection
        
    }
    

    public void UpdateVisual()
    {
        foreach (Item item in items.Values)
        {
            if(inventoryVisual.transform.childCount > 0)
            {
                foreach (Transform child in inventoryVisual.transform)
                {
                    
                    if(child != null && child.GetComponent<Item>() && item.guid == child.GetComponent<Item>().guid ) //Make sure we don't add an already existing item to the list.d
                    {
                        continue;
                    }
                    else
                    {
                         item.inventoryGfx = Instantiate(item.gfx, inventoryVisual.transform); //Add item.
                    }
                    
                }
            }
            else
            {
                //Debug.Log("Made a thing");
                item.inventoryGfx = Instantiate(item.gfx, inventoryVisual.transform); //Really only called when there are no items.
            }
            
        }
    }

    public Item FindItem(Guid guid)
    {
        Item itemReturn = null;
        foreach (Item item in items.Values)
        {
            if(item.guid == guid)
            {
                itemReturn = item;
            }
        }
        if(itemReturn == null)
        {
            Debug.Log("Tried to find item with: " + guid);
            return null;
        }
        else
        {
            return itemReturn;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
