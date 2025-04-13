using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Item
{
    public string dialog;
    public override void PickedUp()
    {
        Inventory.Instance.AddItem(this);
        DialogController.Instance.Dialog(dialog);
        //Do thing I guess?
        Debug.Log("Picked up");

    }


}
