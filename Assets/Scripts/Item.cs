using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class Item
{
    public Guid guid = Guid.NewGuid();
    public GameObject gfx;
    
    void Start()
    {
        if (guid == Guid.Empty)
        {
            guid = Guid.NewGuid();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
