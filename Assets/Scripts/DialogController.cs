using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    /// <summary>
    /// Basically just get component and call this in any if statement. For example, you can check the invintory if the player has a key. If not, then run dialog.
    /// </summary>
    /// 


    public static DialogController Instance;

    public TMP_Text text;
    public GameObject canvas;

    private bool isTyping = false;

    public float typingSpeed = 0.1f;

    private Animator anim;
    private int charIndex;
    private string fullMessage;
    private float timer;


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

    private void Start()
    {
        anim = GetComponent<Animator>();    
        
    }


    public void Dialog(string message)
    {
        text.text = "";
        isTyping = true;
        timer = 0;
        charIndex = 0;
        canvas.SetActive(true);
        fullMessage = message;
    }

    private void Update()
    {
        if (!isTyping) return;

        timer += Time.deltaTime;
        while (timer > typingSpeed && charIndex < fullMessage.Length)
        {
            timer -= typingSpeed;
            text.text += fullMessage[charIndex];
            charIndex++;

            if(charIndex >= fullMessage.Length)
            {
                isTyping = false;
                anim.Play("Fade");
            }
        }
    }

    //Called by anim
    private void TurnOff()
    {
        canvas.SetActive(false);

    }
}
