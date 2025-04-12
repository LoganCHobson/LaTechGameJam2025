using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RenderManager : MonoBehaviour
{
    public Material material;
    public Shader[] shaders;
    
    public void ChangeRenderFeature(int i)
    {
        material.shader = shaders[i];
    }
}
