using UnityEngine;

public class CollectScore : MonoBehaviour{

	public AudioSource collectPoint;
	public AudioClip collectBoost;

	void OnTriggerEnter(Collider other){
		if(gameObject.CompareTag("SpeedBoost") == true){
			AudioSource.PlayClipAtPoint(collectBoost, transform.position);
			Debug.Log("Not in else");
		}else{
			collectPoint.Play();
			Debug.Log("In else");
		}
		Scoring.theScore += 1;
		Destroy(gameObject);
    }
}