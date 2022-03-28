using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppClose : MonoBehaviour{
	void Start(){
		
	}
	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
			Debug.Log("Quit");
		}
	}
}
