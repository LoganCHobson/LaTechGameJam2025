using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RenderManager : MonoBehaviour
{
    public Material material;
    public Shader[] shaders; 
    
    public void ChangeRenderFeature(modes mode)
    {
        material.shader = shaders[(int)mode];
    }
}

public enum modes
{
    None = 0,
    Infared = 1,
    Red = 2,
    Green = 3,

}