using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    public GameObject quit;
    public GameObject start;
    public GameObject menuReturn;
    public GameObject controls;
    public GameObject controlList;
    public void OnObjClick(){
        quit.SetActive(false);
        start.SetActive(false);
        controls.SetActive(false);
        menuReturn.SetActive(true);
        controlList.SetActive(true);
    }
}
