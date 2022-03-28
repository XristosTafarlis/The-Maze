using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFps : MonoBehaviour{

	public int FPS = 144;

    void Start(){
        QualitySettings.vSyncCount = 0;
    }
    void Update(){
    	if (FPS != Application.targetFrameRate){
    		Application.targetFrameRate = FPS;
    	}
    }

}

