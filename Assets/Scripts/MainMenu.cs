using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public LevelTransition levelTransition;

    public GameObject eventGrab;
    void Start()
    {
        eventGrab.GetComponent<RenderManager>().ChangeRenderFeature(modes.None);   
    }
    public void OnClick()
    {
        levelTransition.LoadNextArea();
    }

    public void OnClickQuit()
    {
        Application.Quit();
    }
}
