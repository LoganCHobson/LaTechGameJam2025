using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCooldown : MonoBehaviour
{
    public void BlueCool()
    {
        if(Game.Instance.render.mode == modes.Blue)
        {
            Debug.Log("Switching to grey.");
            Game.Instance.render.ChangeRenderFeature(modes.Grey);
        }
        else
        {
            Debug.Log("No need to switch. The render is:  " + Game.Instance.render.mode + " And we are: " + modes.Blue);
            return; 
        }
    }
    public void RedCool()
    {
        if (Game.Instance.render.mode == modes.Red)
        {
            Debug.Log("Switching to grey.");
            Game.Instance.render.ChangeRenderFeature(modes.Grey);
        }
        else
        {
            Debug.Log("No need to switch. The render is:  " + Game.Instance.render.mode + " And we are: " + modes.Red);
            return;
        }
    }
    public void GreenCool()
    {
        if (Game.Instance.render.mode == modes.Green)
        {
            Debug.Log("Switching to grey.");
            Game.Instance.render.ChangeRenderFeature(modes.Grey);
        }
        else
        {
            Debug.Log("No need to switch. The render is:  " + Game.Instance.render.mode + " And we are: " + modes.Green);
            return;
        }
    }
}
