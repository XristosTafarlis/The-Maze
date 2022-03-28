using UnityEngine;
using System.Collections;
 
public class UpDownScript : MonoBehaviour{
	public AnimationCurve myCurve;
	public int ExtraHeight = 1;
	public int yspeed = 50;
   
	void Update(){
		transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)) + ExtraHeight, transform.position.z);
		transform.Rotate( 0, yspeed * Time.deltaTime, 0);
	}
}