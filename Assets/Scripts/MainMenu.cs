using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject eventGrab;
    void Start()
    {
     eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.Grey);   
    }
    public void OnClick()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
