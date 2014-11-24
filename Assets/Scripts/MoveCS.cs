using UnityEngine;
using System.Collections;

public class MoveCS : MonoBehaviour {
	public float movementSpeed = 0.1f;
	public float turningSpeed = 60;
	public int flag = 0;
	public GameObject walkButton;
	// Update is called once per frame
	void Update () {
		// For the camera movement inside the scene
		// Remove the comment of below line to add auto movement
		//transform.position += transform.forward * Time.deltaTime * movementSpeed;
		UIEventListener.Get(walkButton).onClick += MyClickFunction;
	}

	public void MyClickFunction(GameObject g){
		//if ( Input.GetButtonDown("Fire1") ) // Trying to get a look at control here
		//{
		if(flag==0){flag=1;}
		else{flag=0;}
		//}
		
		if (flag == 1) {
			startMove ();
		} 
	}

	public void startMove(){
		transform.position += transform.forward * Time.deltaTime * movementSpeed;
	}
}
