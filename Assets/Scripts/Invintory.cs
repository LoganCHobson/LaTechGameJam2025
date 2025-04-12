using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invintory : MonoBehaviour
{
    public Dictionary<Guid, Item> items = new Dictionary<Guid, Item>();
    public GameObject invintoryVisual;
    public void AddItem(Item item)
    {
        items.Add(item.guid, item);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
