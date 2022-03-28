using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour{

	public AudioSource collectPoint;

	void OnTriggerEnter(Collider other){
		collectPoint.Play();
		Scoring.theScore += 1;
		Destroy(gameObject);
    }
}
