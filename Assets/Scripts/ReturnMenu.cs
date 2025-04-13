using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
public GameObject quit;
    public GameObject start;
    public GameObject menuReturn;
    public GameObject controls;
    public GameObject controlList;

    public void OnObjClick(){
        quit.SetActive(true);
        start.SetActive(true);
        controls.SetActive(true);
        controlList.SetActive(false);
        menuReturn.SetActive(false);
    }
}
