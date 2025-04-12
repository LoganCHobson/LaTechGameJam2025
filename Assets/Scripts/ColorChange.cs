using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour{

    bool color1;
    bool color2;
    bool color3;
    bool complete;
    ShaderColors color;

    public enum ShaderColors {
        BLACKANDWHITE,
        RED,
        GREEN,
        BLUE,
        FULL,
    }
    
    void Start(){
        color = ShaderColors.BLACKANDWHITE;
    }

    void Update(){
        color1 = Eye1.isGrabbed;
        if (color1){
            color1 = false;
            Eye1.clearGrab();
            ChangeColor(ShaderColors.RED);
        }
        else if (color2){
            color2 = false;

            ChangeColor(ShaderColors.GREEN);
        }
        else if (color3){
            color3 = false;

            ChangeColor(ShaderColors.BLUE);
        }

    }
    public void ChangeColor(ShaderColors newColor){
        if (color != newColor){
            color = newColor;
        }

        //changing the colors below
        if (color == ShaderColors.RED){

        }
        else if (color == ShaderColors.GREEN){

        }
        else if (color == ShaderColors.BLUE){

        }
        else if (color == ShaderColors.FULL){
            
        }

    }

}
