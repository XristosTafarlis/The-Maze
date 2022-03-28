using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour{

	public AudioSource NopeSound;

    void OnTriggerEnter (Collider other){
    	if (SceneManager.GetActiveScene().buildIndex == 1 && Scoring.theScore == 3){
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	}else if(SceneManager.GetActiveScene().buildIndex == 2 && (Scoring.theScore == 6 || Scoring.theScore == 7)){
    		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    	}else{
    		NopeSound.Play();
    	}
	}
}
