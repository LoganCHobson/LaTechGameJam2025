using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RenderManager : MonoBehaviour
{
    public Material material;
    public Shader[] shaders;

    public modes mode;
    
    public void ChangeRenderFeature(modes _mode)
    {
        mode = _mode;
        material.shader = shaders[(int)_mode];
    }
}

public enum modes
{
    None = 0,
    Grey = 1,
    Red = 2,
    Green = 3,
    Blue = 4,
    RedBlue = 5,
    RedGreen = 6,
    GreenBlue = 7,


}