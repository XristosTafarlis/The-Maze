using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndFadeIn : MonoBehaviour{
    public Image FadeIn;
    public int FadeTime = 4; 
    void Start(){
        FadeIn.canvasRenderer.SetAlpha(1);
    	fadeOut();
    }

    void fadeOut(){
        FadeIn.CrossFadeAlpha(0, FadeTime, false);
    }
}
	