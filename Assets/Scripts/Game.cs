using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public GameObject mainMenuScreen;
    public GameObject gameOverlay;
    public GameObject pauseMenu;
    public RenderManager render;

    public static Game Instance;
    public GameObject Red;
    public GameObject Blue;
    public GameObject Green;
    public GameObject RedBlue;
    public GameObject RedGreen;
    public GameObject GreenBlue;


    public Slider slider;
    public Animator anim;

    public float timer = 36000;
    private float time;
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

    void Start()
    {
        slider.value = 0;
        slider.maxValue = timer;
        DialogController.Instance.Dialog("Another dreary day. . Maybe if I can make it to the field to watch the sunset it'll get better. .");

        time = 0;
        
        mainMenuScreen.SetActive(true);
        render.GetComponent<RenderManager>().ChangeRenderFeature(modes.Grey);
        Instance = this;
        Red.SetActive(false);
        Green.SetActive(false);
        Blue.SetActive(false);
        Green.SetActive(false);

        render = GetComponent<RenderManager>();
        render.ChangeRenderFeature(modes.Grey);
    }
    public void StartGame()
    {
        mainMenuScreen.SetActive(false);
        render.ChangeRenderFeature(modes.Grey);
    }
    public void PauseGame()
    {
        if (pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
        }
        else
        {
            pauseMenu.SetActive(true);
        }
    }
    public static void GameComplete()
    {
        Debug.Log("You did it!");
    }
    void Update()
    {
        time += Time.deltaTime;
        slider.value = time;


        if(time >= timer)
        {
            SceneManager.LoadScene("Gameplay");
        }


        if (Input.GetKey(KeyCode.Escape))
        {
            PauseGame();
        }
        if (Input.GetKey(KeyCode.Alpha1) && Red.activeInHierarchy)
        {
            
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FadeRed"))
            {
                return;
            }
            else
            {
                render.ChangeRenderFeature(modes.Red);
                anim.Play("FadeRed");
            }

        }
        if (Input.GetKey(KeyCode.Alpha2) && Green.activeInHierarchy)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FadeGreen"))
            {
                return;
            }
            else
            {
                render.ChangeRenderFeature(modes.Green);
                anim.Play("FadeGreen");
            }
        }
        if (Input.GetKey(KeyCode.Alpha3) && Blue.activeInHierarchy)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("FadeBlue"))
            {
                return;
            }
            else
            {
                render.ChangeRenderFeature(modes.Blue);
                anim.Play("FadeBlue");
            }
        }
        //if(Input.GetKey(KeyCode.Alpha4) && RedGreen.activeInHierarchy){
        //    render.ChangeRenderFeature(modes.RedGreen);
        //}
        //if(Input.GetKey(KeyCode.Alpha5) && RedBlue.activeInHierarchy){
        //    render.ChangeRenderFeature(modes.RedBlue);
        //}
        //if(Input.GetKey(KeyCode.Alpha6) && GreenBlue.activeInHierarchy){
        //    render.ChangeRenderFeature(modes.GreenBlue);
        //}
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
