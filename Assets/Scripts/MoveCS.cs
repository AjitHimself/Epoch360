using UnityEngine;
using System.Collections;

public class MoveCS : MonoBehaviour {
	public float movementSpeed = 0.1f;
	public float turningSpeed = 60;
	public int flag = 0;
	public GameObject walkButton;
	public GameObject stopButton;

	// Update is called once per frame
	void Update () {
		// For the camera movement inside the scene
		// Remove the comment of below line to add auto movement
		//transform.position += transform.forward * Time.deltaTime * movementSpeed;
		UIEventListener.Get(walkButton).onClick += WalkClickFunction;
		UIEventListener.Get(stopButton).onClick += StopClickFunction;
		if (flag == 1) {
			startMove ();
		} 
	}

	public void WalkClickFunction(GameObject g){
		if(flag==0){flag=1;}
	}
	public void StopClickFunction(GameObject g){
		if(flag==1){flag=0;}
	}
	public void startMove(){
		transform.position += transform.forward * Time.deltaTime * movementSpeed;
	}
}
