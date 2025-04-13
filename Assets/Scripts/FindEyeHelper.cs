using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class FindEyeHelper : Helper
{

    public override void Execute(string message, GameObject obj)
    {
        if (!obj.activeInHierarchy)
        {
            DialogController.Instance.Dialog(message);
        }
    }
}
