using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScenePoints : MonoBehaviour{
	public GameObject Text;
	public static int Score;

	void Update(){
		if(Scoring.theScore == 6){
			Text.GetComponent<Text>().text = "You collected all 6 of the hidden points, well done!";
		}else{
			Text.GetComponent<Text>().text = "You collected 6 hidden points and you found the Blue Diamond!";
		}
	}
}
