using UnityEngine;
using System.Collections;

public class MoveCS : MonoBehaviour {
	public float movementSpeed = 1;
	public float turningSpeed = 60;
	//public Vector3 face;
	// Update is called once per frame
	void Update () {
		//float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		//transform.Rotate(0, horizontal, 0);
		//float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		//transform.Translate(0, 0, vertical);
		transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
	}
}
