using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
    public override void PickedUp()
    {
        Inventory.Instance.AddItem(this);
        //Do thing I guess?
        Debug.Log("Picked up");

    }


}
